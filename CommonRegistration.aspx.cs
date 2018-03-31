using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CommonRegistration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button_UserRegistration_Click(object sender, EventArgs e)
    {
        Response.Redirect("UserRegistration.aspx");
    }
    protected void Button_HrRegistration_Click(object sender, EventArgs e)
    {
        Response.Redirect("HrRegistration.aspx");
    }
}