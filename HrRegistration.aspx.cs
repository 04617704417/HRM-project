using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class HrRegistration : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
    SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        cmd = new SqlCommand("Insert into HRRegistration values ('" + Text_Name.Text + "','" + Text_HR_ID.Text + "','" + Text_Password.Text + "','" + Text_ConfirmPassword.Text + "','" + Text_contactNo.Text + "','" + Text_EmailId.Text + "','" + Text_DOB.Text + "','" + RadioButton_Gender.SelectedIndex + "', '" + Text_Add.Text + "', '" + DropDown_City.SelectedIndex + "', '" + Text_Workedskills.Text + "','" + Text_Designation.Text + "','" + Text_Workexperience.Text + "','" + Text_Status.Text + "' )", con);
        cmd.ExecuteNonQuery();
        Response.Write("<script>alert('Record submitted successfully')</script>");
        con.Close();


    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Text_Name.Text = " ";
        Text_HR_ID.Text = " ";
        Text_Password.Text = " ";
        Text_ConfirmPassword.Text = " ";
        Text_contactNo.Text = " ";
        Text_EmailId.Text = " ";
        Text_DOB.Text = " ";
        RadioButton_Gender.SelectedIndex = 0;
        Text_Add.Text = " ";
        DropDown_City.SelectedIndex = 0;
        Text_Workedskills.Text = " ";
        Text_Designation.Text = " ";
        Text_Workexperience.Text = " ";
        Text_Status.Text = " ";

    }

}