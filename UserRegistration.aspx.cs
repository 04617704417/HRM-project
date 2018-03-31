using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class UserRegistration : System.Web.UI.Page
{

    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
    SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
        con.Open();
        cmd = new SqlCommand("Insert into UserRegistration values ('" + TextBox1.Text + "','" + TextBox_UserID.Text + "','" + TextBox6.Text + "','" + TextBox8.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + RadioButtonList1.SelectedItem.Text + "','" + TextBox7.Text + "', '" + DropDownList1.SelectedItem.Text + "')", con);
        cmd.ExecuteNonQuery();
        Response.Write("<script>alert('Record submitted successfully')</script>");
        con.Close();

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = " ";
        TextBox_UserID.Text = " ";
        TextBox6.Text = " ";
        TextBox8.Text = " ";
        TextBox3.Text = " ";
        TextBox4.Text = " ";
        TextBox5.Text = " ";
        RadioButtonList1.SelectedIndex = 0;
        TextBox7.Text = " ";
        DropDownList1.SelectedIndex = 0;


    }
}