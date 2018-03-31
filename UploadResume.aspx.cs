using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class UploadResume : System.Web.UI.Page
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
            Response.Redirect("UserLogin.aspx");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        string pathname;
        string photopath;
        pathname = @"~\UploadFile\" + resumupload.FileName;   // To fetch the full pathname of file
        resumupload.PostedFile.SaveAs(Server.MapPath(pathname));  // To upload file 
        photopath = @"~\UploadFile\" + photoupload.FileName;   // To fetch the full pathname of file
        photoupload.PostedFile.SaveAs(Server.MapPath(photopath));  // To upload file 
        cmd = new SqlCommand("Insert into ResumeUpload values ('" + Apllicant + "','" + pathname + "', '" + photopath + "' )", con);
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