using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class UpdateYourDetails : System.Web.UI.Page
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
        SqlCommand cmd = new SqlCommand("UPDATE UserRegistration  SET Your_Name='" + Text_Name.Text + "',Contact_no=" + Text_Contact.Text + ",email_id='" + Text_Email_ID.Text + "',DOB ='" + Text_DOB.Text + "',Gender='" + RadioButton_Gender.SelectedItem + "',AddRess='" + Text_Add.Text + "' where Id=" + Session["Applicant"].ToString() + " ", conn);
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
        SqlCommand cmd = new SqlCommand("SELECT Your_Name,Contact_no,email_id,DOB,Gender,AddRess,City FROM UserRegistration where Id=" + Session["Applicant"].ToString() + "", conn);
        SqlDataReader dr = cmd.ExecuteReader
            ();
        if (dr.HasRows)
        {
            while (dr.Read())
            {
                Text_Name.Text = dr[0].ToString();
                Text_Contact.Text = dr[1].ToString();
                Text_Email_ID.Text = dr[2].ToString();
                Text_DOB.Text = dr[3].ToString();
                RadioButton_Gender.SelectedValue = dr[4].ToString();
                Text_Add.Text = dr[5].ToString();


            }
        }
        conn.Close();
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Session.Abandon();
    }
}