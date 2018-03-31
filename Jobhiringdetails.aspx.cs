using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Jobhiringdetails : System.Web.UI.Page
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
        if (!IsPostBack)
        {
            getjob();
            BindHrName();
            BindUserName();
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
    void BindUserName()
    {
        SqlDataAdapter da = new SqlDataAdapter("select  Your_Name,Id from UserRegistration", con);

        DataTable dt = new DataTable();
        da.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            DropDownList_Candidate.DataSource = dt;
            DropDownList_Candidate.DataTextField = "Your_Name";
            DropDownList_Candidate.DataValueField = "Id";
            DropDownList_Candidate.DataBind();
        }
        DropDownList_Candidate.Items.Insert(0, "Select HR Name");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        cmd = new SqlCommand("Insert into jobhiring values ('" + DropDownList1.SelectedValue + "'," + DropDownList_HRName.SelectedValue + ",'" + DropDownList_Candidate.SelectedValue + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "')", con);
        cmd.ExecuteNonQuery();
        Response.Write("Record submitted successfully");
        con.Close();
    }
    void getjob()
    {

        SqlDataAdapter da = new SqlDataAdapter("SELECT ID,Tittle FROM job", con);
        DataTable dt = new DataTable();
        da.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            DropDownList1.DataSource = dt;
            DropDownList1.DataTextField = "Tittle";
            DropDownList1.DataValueField = "ID";
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, "Select");
        }

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        //TextBox1.Text = " ";
        DropDownList_HRName.SelectedIndex = 0;
        //TextBox3.Text = " "; 
        TextBox4.Text = " ";
        TextBox5.Text = " ";
        TextBox6.Text = " ";
    }
}