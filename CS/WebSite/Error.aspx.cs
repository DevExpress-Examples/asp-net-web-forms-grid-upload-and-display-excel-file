﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;

public partial class Error : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {
        string errorMessage = ASPxWebControl.GetCallbackErrorMessage();
        Response.Output.Write(errorMessage);
    }
}