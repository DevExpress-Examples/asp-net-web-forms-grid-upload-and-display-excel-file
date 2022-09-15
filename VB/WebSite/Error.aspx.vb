Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web

Partial Public Class [Error]
	Inherits System.Web.UI.Page

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim errorMessage As String = ASPxWebControl.GetCallbackErrorMessage()
		Response.Output.Write(errorMessage)
	End Sub
End Class