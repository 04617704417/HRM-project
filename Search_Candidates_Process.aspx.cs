using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Search_Candidates_Process : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
    string HRAdmin;
    SqlCommand cmd;
    protected void Page_Load(object sender, EventArgs e)
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
    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();

        string sqlquery;
        if (CheckBox_Pstgrad.Checked == true)
        {
            sqlquery = "SELECT USERID,Graduation_Course,Graduation_Percentage,Graduation_UniversityBoard,PostGraduation_Course,PostGraduation_Percentage,PostGraduation_UniversityBoard,PostGraduation_Passing_year FROM Educationaldetailss WHERE PostGraduation_Percentage > 50";
            SqlDataAdapter da = new SqlDataAdapter(sqlquery, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                grid1.DataSource = dt;
                grid1.DataBind();
            }
            return;
        }

        if (CheckBox_grad.Checked == true)
        {
            sqlquery = "SELECT USERID,XII_Course,XII_UniversityBoard,Graduation_Course,Graduation_Percentage,Graduation_UniversityBoard,Graduation_UniversityBoard FROM Educationaldetailss WHERE Graduation_Percentage > 50";
            SqlDataAdapter da = new SqlDataAdapter(sqlquery, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                grid1.DataSource = dt;
                grid1.DataBind();
            }
            return;
        }

        if (CheckBox_12.Checked == true)
        {
            sqlquery = "SELECT USERID, X_Course,X_UniversityBoard,XII_Course,XII_UniversityBoard,XII_Passing_year FROM Educationaldetailss WHERE XII_Percentage > 50";
            SqlDataAdapter da = new SqlDataAdapter(sqlquery, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                grid1.DataSource = dt;
                grid1.DataBind();
            }
            return;

        }
        if (CheckBox_10.Checked == true)
        {
            sqlquery = "SELECT USERID, X_Course,X_UniversityBoard, X_Passing_year FROM Educationaldetailss WHERE X_Percentage > 50";
            SqlDataAdapter da = new SqlDataAdapter(sqlquery, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                grid1.DataSource = dt;
                grid1.DataBind();
            }
            return;

        }
        if (CheckBox_Certificate.Checked == true)
        {
            sqlquery = "SELECT USERID, X_Course,X_UniversityBoard, X_UniversityBoard,Certificate_Course,Certificate_UniversityBoard,Certificate_Passing_year FROM Educationaldetailss WHERE Certificate_Percentage > 50";
            SqlDataAdapter da = new SqlDataAdapter(sqlquery, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                grid1.DataSource = dt;
                grid1.DataBind();
            }
            return;

        }
        if (CheckBox_Additional.Checked == true)
        {
            sqlquery = "SELECT USERID, X_Course,X_UniversityBoard, X_UniversityBoard,Additional_Course,Additional_UniversityBoard,Additional_Passing_year FROM Educationaldetailss WHERE Additional_Percentage > 50";
            SqlDataAdapter da = new SqlDataAdapter(sqlquery, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                grid1.DataSource = dt;
                grid1.DataBind();
            }
            return;

        }

    }
}