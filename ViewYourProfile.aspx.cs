using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class ViewYourProfile : System.Web.UI.Page
{
    string Apllicant;
    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {

        Apllicant = (string)Session["Applicant"];
        try
        {
            if (!(Session["Applicant"].ToString().Equals("")))
            {
                update();
            }
        }
        catch (Exception ex)
        {
            Response.Redirect("UserLogin.aspx");
        }




    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        conn.Open();
        SqlCommand cmd = new SqlCommand("UPDATE UserRegistration  SET Your_Name='" + TextBox1.Text + "',userId=" + TextBox_UserID.Text + ",Password='" + TextBox6.Text + "' ,Contact_no=" + TextBox3.Text + ",email_id='" + TextBox4.Text + "',DOB ='" + TextBox5.Text + "',Gender='" + RadioButtonList1.SelectedItem + "',AddRess='" + TextBox7.Text + "' , City='" + DropDownList1.SelectedItem.Text + "' WHERE Id=" + Session["Applicant"].ToString() + "", conn);
        int i = cmd.ExecuteNonQuery();
        if (i > 0)
        {
            Response.Write("<script>alert('Record updated successfully!!!!!!')</script>");
            return;
        }
        conn.Close();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {

    }
    void update()
    {
        conn.Open();
        SqlCommand cmd = new SqlCommand("SELECT Your_Name,userId,Password,Contact_no,email_id,DOB,Gender,AddRess, City FROM UserRegistration WHERE Id=" + Session["Applicant"].ToString() + "", conn);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            while (dr.Read())
            {
                TextBox1.Text = dr[0].ToString();
                TextBox_UserID.Text = dr[1].ToString();
                TextBox6.Text = dr[2].ToString();
                TextBox3.Text = dr[3].ToString();
                TextBox4.Text = dr[4].ToString();
                TextBox5.Text = dr[5].ToString();
                RadioButtonList1.SelectedValue = dr[6].ToString();
                TextBox7.Text = dr[7].ToString();
                DropDownList1.SelectedValue = dr[8].ToString();


            }
        }
        conn.Close();
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Session.Abandon();
        Response.Redirect("Home.aspx");
    }
}