using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class CmpletRegistrationform : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
    SqlCommand cmd;
    string Apllicant;
    protected void Page_Load(object sender, EventArgs e)
    {

        Apllicant = (string)Session["Applicant"];
        try
        {
            if (!(Session["Applicant"].ToString().Equals("")))
            {

            }
        }
        catch (Exception ex)
        {
            Response.Redirect("UserLogin.aspx");
        }

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Session.Abandon();
    }
}