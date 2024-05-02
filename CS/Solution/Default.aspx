<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Solution.Default" %>

<%@ Register Assembly="DevExpress.Web.ASPxSpreadsheet.v22.1, Version=22.1.14.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxSpreadsheet" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function OnFileUploadComplete(s, e) {
            Grid.PerformCallback();
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <dx:ASPxUploadControl ID="Upload" runat="server" ShowUploadButton="True" OnFileUploadComplete="Upload_FileUploadComplete">
                <ValidationSettings AllowedFileExtensions=".xls,.xlsx">
                </ValidationSettings>
                <ClientSideEvents FileUploadComplete="OnFileUploadComplete" />
            </dx:ASPxUploadControl>
            <dx:ASPxGridView ID="Grid" ClientInstanceName="Grid" runat="server" OnInit="Grid_Init"></dx:ASPxGridView>
        </div>
    </form>
</body>
</html>
