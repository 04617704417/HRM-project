using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.OleDb;
using System.Web.Mail;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;
using System.Net;
using System.Text.RegularExpressions;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class MailAlert : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
    string HRAdmin;
    SqlCommand cmd;
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
            SqlDataAdapter da = new SqlDataAdapter("SELECT Email_Id,Your_Name FROM UserRegistration", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Drop_UserID.DataSource = dt;
                Drop_UserID.DataTextField = "Your_Name";
                Drop_UserID.DataValueField = "Email_Id";
                Drop_UserID.DataBind();
                Drop_UserID.Items.Insert(0, "Select");
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        conn.Open();
        cmd = new SqlCommand("Insert into MailAlert values ('" + Drop_UserID.SelectedValue + "','" + Text_Massages.Text + "')", conn);
        cmd.ExecuteNonQuery();
        Response.Write("Record submitted successfully");
        conn.Close();

        // MailMessage msg = new MailMessage();
        //msg.To.Add(Drop_UserID.SelectedValue.ToString());
        //msg.From = new MailAddress("Rahulcpj8@gmail.com");
        //msg.Subject = "Alert from website name";
        //msg.IsBodyHtml = true;
        //msg.Body = Text_Massages.Text;
        //SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
        //smtp.EnableSsl = true;
        //smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
        //smtp.UseDefaultCredentials = false;
        //smtp.Send(msg);
        Response.Write("</script>alert('Alert send successfully')</script>");
    }

}