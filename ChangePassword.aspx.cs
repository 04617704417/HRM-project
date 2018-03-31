using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class ChangePassword : System.Web.UI.Page
{
    string Apllicant;
    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            update();
        }


        if (Session["Applicant"] == null && Session["HR Admin"] == null)
        {
            Response.Redirect("UserLogin.aspx");
        }




    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (DropDownList_UserType.SelectedItem.Text == "HR")
        {
            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter("select Password from  HRRegistration where HR_Id=" + Session["HR Admin"].ToString() + " and Password='" + Text_Old_Password.Text + "' ", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                SqlCommand cmd = new SqlCommand(" UPDATE HRRegistration  SET Password='" + TextBox2.Text + "', Confirm_Password='" + TextBox3.Text + "' WHERE HR_Id='" + Session["HR Admin"].ToString() + "' ", conn);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    Response.Write("<script>alert('Record updated successfully!!!!!!')</script>");

                }

            }
            else
            {
                Response.Write("<script>alert('Sorry Invalid Old Password')</script>");
            }

            conn.Close();
        }

        if (DropDownList_UserType.SelectedItem.Text == "User")
        {
            conn.Open();

            SqlDataAdapter cmdcheck1 = new SqlDataAdapter("select Password from  UserRegistration where userId=" + Session["Applicant"].ToString() + " and Password='" + Text_Old_Password.Text + "' ", conn);
            DataTable  drcheck1 = new DataTable ();
            cmdcheck1.Fill(drcheck1);
            if (drcheck1.Rows.Count > 0)
            {
                SqlCommand cmd = new SqlCommand(" UPDATE UserRegistration  SET Password='" + TextBox2.Text + "', Confirm_Password='" + TextBox3.Text + "' where userId=" + Session["Applicant"].ToString() + "", conn);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    Response.Write("<script>alert('Record updated successfully!!!!!!')</script>");

                }
                else
                {
                    Response.Write("<script>alert('Sorry Invalid Old Password')</script>");
                }
            }
            
            

            conn.Close();
        }

    }
    protected void Button2_Click(object sender, EventArgs e)
    {

    }
    void update()
    {
        conn.Open();
        SqlCommand cmd = new SqlCommand("SELECT Password,Confirm_Password FROM HRRegistration where HR_Id=" + Session["HR Admin"].ToString() + " and Password='" + Text_Old_Password.Text + "' ", conn);
        SqlDataReader dr = cmd.ExecuteReader
            ();
        if (dr.HasRows)
        {
            while (dr.Read())
            {
                TextBox2.Text = dr[0].ToString();
                TextBox3.Text = dr[1].ToString();


            }
        }
        conn.Close();
    }
}