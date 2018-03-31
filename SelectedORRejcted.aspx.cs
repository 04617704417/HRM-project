using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class SelectedORRejcted : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
    SqlCommand cmd;
    SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Applicant"] == null)
        {
            Response.Redirect("UserLogin.aspx");
        }

        if (!IsPostBack)
        {
            con.Open();
            cmd = new SqlCommand("select * from selectcandidate where Candidate_ID=" + Session["Applicant"].ToString() + "", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                Label_Status.Text = "Congratulations You Have Selected !!!!! <br> Our Team will get back to u shortly for Next phase";
            }
            con.Close();
            SqlDataAdapter daCheck = new SqlDataAdapter("select * from Rejactedcandidate where UserID=" + Session["Applicant"].ToString() + "", con);
            DataTable dt = new DataTable();
            daCheck.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Label_Status.Text = "Sorry You Have Not Selected";
            }


        }


    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Session.Abandon();
    }
}