using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class jobtable : System.Web.UI.Page
{

    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
    SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        cmd = new SqlCommand("Insert into job values ('" + Text_Tittle.Text + "','" + Text_Description.Text + "'," + Text_NOofvacancies.Text + ",'" + Text_Skill_Req_1.Text + "','" + Text_Skill_Req_2.Text + "','" + Text_Skill_Req_3.Text + "','" + Text_Last_date_of_apply.Text + "', '" + Text_Date_of_Interview.Text + "','" + Text_Location_of_Interview.Text + "')", con);
        cmd.ExecuteNonQuery();
        Response.Write("Record submitted successfully");
        con.Close();

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        //Text_ID.Text = " ";
        Text_Tittle.Text = " ";
        Text_Description.Text = " ";
        Text_NOofvacancies.Text = " ";
        Text_Skill_Req_1.Text = " ";
        Text_Skill_Req_2.Text = " ";
        Text_Skill_Req_3.Text = " ";
        Text_Last_date_of_apply.Text = " ";
        Text_Date_of_Interview.Text = " ";
        Text_Location_of_Interview.Text = " ";
    }
}