using DevExpress.Web;
using System;

namespace Solution {
    public partial class Error : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            string errorMessage = ASPxWebControl.GetCallbackErrorMessage();
            Response.Output.Write(errorMessage);
        }
    }
}