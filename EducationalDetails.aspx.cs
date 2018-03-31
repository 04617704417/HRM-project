using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class EducationalDetails : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
    SqlCommand cmd;
    string Apllicant;
    protected void Page_Load(object sender, EventArgs e)
    {
        Apllicant = (string)Session["Applicant"];
        try
        {
            if (!(Session["Applicant"].ToString().Equals("")))
            {

            }
        }
        catch (Exception ex)
        {
            Response.Redirect("UserLogin.aspx"+ ex);
        }


    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        cmd = new SqlCommand("Insert into  Educationaldetailss values ('" + Session["Applicant"].ToString() + "','" + TextBox_course10.Text + "','" + TextBoxPer10.Text + "','" + TextUniversity10.Text + "','" + DropDownList1.SelectedValue + "','" + TextBox_course12.Text + "','" + TextBoxPer12.Text + "','" + TextUniversity12.Text + "','" + DropDownList2.SelectedValue + "','" + DropDownList4.SelectedValue + "','" + TextBoxPergrd.Text + "','" + TextUniversityGrad.Text + "', '" + DropDownList3.SelectedValue + "','" + DropDownList5.SelectedValue + "','" + TextBoxPerPd.Text + "','" + TextUniversityPostGradu.Text + "', '" + DropDownList6.SelectedValue + "','" + TextBox_courseCert.Text + "','" + TextBoxPercetf.Text + "','" + TextUniversityCertic.Text + "','" + DropDownList8.SelectedValue + "','" + TextBox_courseAdditional.Text + "','" + TextBoxadddip.Text + "','" + TextUniversityAdditional.Text + "','" + DropDownList7.SelectedValue + "')", con);
        cmd.ExecuteNonQuery();
        Response.Write("<script>alert('Record submitted successfully')</script>");
        con.Close();
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Session.Abandon();
    }
}