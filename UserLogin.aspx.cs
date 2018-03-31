using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class UserLogin : System.Web.UI.Page
{

    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
    SqlCommand cmd;
    SqlDataReader dr;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();

        if (DropDownList1.SelectedItem.ToString() == "Applicant")
        {
            cmd = new SqlCommand("select Id  from UserRegistration WHERE  UserId='" + Text_User_Id.Text + "'  and Password= '" + Test_Password.Text + "'", con);
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Session["Applicant"] = dr[0].ToString();
                    Response.Redirect("CmpletRegistrationform.aspx");
                }
            }
        }
        if (DropDownList1.SelectedItem.ToString() == "HR Admin")
        {
            cmd = new SqlCommand("select HR_Id, Password  from HRRegistration WHERE  HR_Id='" + Text_User_Id.Text + "'  and Password= '" + Test_Password.Text + "'", con);
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                Session["HR Admin"] = Text_User_Id.Text;
                Response.Redirect("HRCompletRegistration.aspx");
            }
            con.Close();

        }

        else
        {
            Response.Write("sorry invalid user ID or Password");
        }
    }
}