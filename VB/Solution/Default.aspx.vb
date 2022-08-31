Imports DevExpress.Spreadsheet
Imports DevExpress.Spreadsheet.Export
Imports System
Imports System.Data
Imports System.Web.UI

Partial Public Class _Default
    Inherits Page

    Private Property FilePath() As String
        Get
            Return If(Session("FilePath") Is Nothing, String.Empty, Session("FilePath").ToString())
        End Get
        Set(ByVal value As String)
            Session("FilePath") = value
        End Set
    End Property
    Protected Sub Page_PreInit(ByVal sender As Object, ByVal e As EventArgs)
        If Not IsPostBack Then
            FilePath = String.Empty
        End If
    End Sub
    Protected Sub Upload_FileUploadComplete(ByVal sender As Object, ByVal e As DevExpress.Web.FileUploadCompleteEventArgs)
        FilePath = Page.MapPath("~/XlsTables/") & e.UploadedFile.FileName
        e.UploadedFile.SaveAs(FilePath)
    End Sub
    Private Function GetTableFromExcel() As DataTable
        Dim book As New Workbook()
        AddHandler book.InvalidFormatException, AddressOf book_InvalidFormatException
        book.LoadDocument(FilePath)
        Dim sheet As Worksheet = book.Worksheets.ActiveWorksheet
        Dim range As CellRange = sheet.GetUsedRange()
        Dim table As DataTable = sheet.CreateDataTable(range, False)
        Dim exporter As DataTableExporter = sheet.CreateDataTableExporter(range, table, False)
        AddHandler exporter.CellValueConversionError, AddressOf exporter_CellValueConversionError
        exporter.Export()
        Return table
    End Function

    Private Sub exporter_CellValueConversionError(ByVal sender As Object, ByVal e As CellValueConversionErrorEventArgs)
        e.Action = DataTableExporterAction.Continue
        e.DataTableValue = Nothing
    End Sub
    Private Sub book_InvalidFormatException(ByVal sender As Object, ByVal e As SpreadsheetInvalidFormatExceptionEventArgs)

    End Sub

    Protected Sub Grid_Init(ByVal sender As Object, ByVal e As EventArgs)
        If Not String.IsNullOrEmpty(FilePath) Then
            Grid.DataSource = GetTableFromExcel()
            Grid.DataBind()
        End If
    End Sub
End Class