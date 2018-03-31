using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class InterviewSchedule : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
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
            SqlDataAdapter da = new SqlDataAdapter("SELECT Id,Your_Name FROM UserRegistration", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                ddluser.DataSource = dt;
                ddluser.DataTextField = "Your_Name";
                ddluser.DataValueField = "Id";
                ddluser.DataBind();
                ddluser.Items.Insert(0, "Select");
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        conn.Open();
        SqlCommand cmd = new SqlCommand("Insert into Interview values ('" + ddluser.SelectedValue.ToString() + "','" + Text_HRId.Text + "','" + DateTime.Now + "')", conn);

        int i = cmd.ExecuteNonQuery();
        if (i > 0)
        {
            Response.Write("<script>alert('Interview scheduled successfully')</script>");
        }
        Response.Write("Record submitted successfully");
        conn.Close();
    }

}