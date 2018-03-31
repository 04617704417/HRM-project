using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Report : System.Web.UI.Page
{

    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
    SqlCommand cmd;
    string HRAdmin;
    protected void Page_Load(object sender, EventArgs e)
    {
        {

            HRAdmin = (string)Session["Applicant"];
            try
            {
                if (!(Session["HR Admin"].ToString().Equals("")))
                {

                }
            }
            catch (Exception ex)
            {
                Response.Redirect("UserLogin.aspx");
            }
        }
    }
}