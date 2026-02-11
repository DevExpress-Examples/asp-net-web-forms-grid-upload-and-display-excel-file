<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128564672/19.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E5199)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
* [Error.aspx](./CS/WebSite/Error.aspx) (VB: [Error.aspx](./VB/WebSite/Error.aspx))
* [Error.aspx.cs](./CS/WebSite/Error.aspx.cs) (VB: [Error.aspx.vb](./VB/WebSite/Error.aspx.vb))
<!-- default file list end -->
# How to load an excel file to the server using ASPxUploadControl and display its data in ASPxGridView


<p>This example shows how to load an excel file from your computer to the server using <strong>ASP</strong><strong>xUploadControl</strong> and then display its data in <strong>ASPxGridView</strong>.<br>To do this, you first need to place the <strong>ASPxGridView</strong> and <strong>ASPxUploadControl </strong>controls on a page and, secondly, handle the <strong>ASPxGridView.Init </strong>event and both the server-side and the client-side <strong>ASPxUploadControl</strong><strong>.FileUploadComplete</strong> events.<br>After uploading the excel file from your computer, save it in the "~/XlsTables/" directory using the <strong>ASPxUploadControl.FileUploadControl</strong> event handler on the server-side. You may choose any filename and then save it in the <strong>Session["FileName"]</strong> object to use later.<br>In the <strong>ASP</strong><strong>xGridView.</strong><strong>Init </strong>event handler you need to check the value of the <strong>Session</strong><strong>[</strong><strong>"</strong><strong>FileName</strong><strong>"</strong><strong>]</strong> object. If it's <strong>null</strong>, do nothing. Otherwise create a new <strong>DataTable </strong>and <strong>DataTableExporter </strong>objects.<br><br><strong>See also:</strong><br><a href="https://www.devexpress.com/Support/Center/p/T449148">GridView - How to upload an Excel file via UploadControl and display its data in a grid</a><br><a href="https://www.devexpress.com/Support/Center/p/T576892">GridView - How to upload an Excel file via UploadControl and show its data in a grid</a></p>
<p><strong>Note:</strong><br>The DevExpress.Docs assembly is used in this example. So, the <a href="https://www.devexpress.com/Products/NET/Document-Server/">Document Server</a> subscription license is required to implement the demonstrated approach.</p>

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=asp-net-web-forms-grid-upload-and-display-excel-file&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=asp-net-web-forms-grid-upload-and-display-excel-file&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
