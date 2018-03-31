using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class SelactedCandidat : System.Web.UI.Page
{

    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
    SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindHrName();
        }

    }

    void BindHrName()
    {
        SqlDataAdapter da = new SqlDataAdapter("select HR_Name,id from HRRegistration", con);
        DataTable dt = new DataTable();
        da.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            DropDownList_HRName.DataSource = dt;
            DropDownList_HRName.DataTextField = "HR_Name";
            DropDownList_HRName.DataValueField = "id";
            DropDownList_HRName.DataBind();
        }
        DropDownList_HRName.Items.Insert(0, "Select HR Name");

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        con.Open();
        cmd = new SqlCommand("Insert into selectcandidate values ('" + Text_Conversion_ID.Text + "','" + Text_Job_ID.Text + "','" + DropDownList_HRName.SelectedValue.ToString() + "','" + Text_Candidate_ID.Text + "','" + Text_Date_of_Joining.Text + "','" + Text_Reporting_Hanger.Text + "','" + Text_Nature_of_Hiring.Text + "', '" + Text_Offer_Letter_issue.Text + "','" + Text_Joining_Status.Text + "')", con);
        cmd.ExecuteNonQuery();
        Response.Write("Record submitted successfully");
        con.Close();


    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Text_Conversion_ID.Text = " ";
        Text_Job_ID.Text = " ";
        DropDownList_HRName.SelectedIndex = 0;
        Text_Candidate_ID.Text = " ";
        Text_Date_of_Joining.Text = " ";
        Text_Reporting_Hanger.Text = " ";
        Text_Nature_of_Hiring.Text = " ";
        Text_Offer_Letter_issue.Text = " ";
        Text_Joining_Status.Text = " ";
    }

}