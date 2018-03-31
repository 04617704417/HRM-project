using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class RejactedCandidat : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
    SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        cmd = new SqlCommand("Insert into Rejactedcandidate values ('" + Text_User_ID.Text + "','" + Text_Interviewer_ID.Text + "','" + Text_Status_ID.Text + "','" + Text_Remark.Text + "')", con);
        cmd.ExecuteNonQuery();
        Response.Write("Record submitted successfully");
        con.Close();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Text_User_ID.Text = " ";
        Text_Interviewer_ID.Text = " ";
        Text_Status_ID.Text = " ";
        Text_Remark.Text = " ";
    }
}