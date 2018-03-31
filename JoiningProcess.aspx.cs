using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public partial class JoiningProcess : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString);
    SqlCommand cmd;
    SqlDataReader dr;

    protected void Page_Load(object sender, EventArgs e)
    {
        SqlDataAdapter daselected = new SqlDataAdapter("select * from selectcandidate", con);
        DataTable dtSelected = new DataTable();
        daselected.Fill(dtSelected);
        if (dtSelected.Rows.Count > 0)
        {
            GridView1.DataSource = dtSelected;
            GridView1.DataBind();
        }

        SqlDataAdapter daRejected = new SqlDataAdapter("select * from Rejactedcandidate", con);
        DataTable dtRejected = new DataTable();
        daRejected.Fill(dtRejected);
        if (dtRejected.Rows.Count > 0)
        {
            GridView1.DataSource = dtRejected;
            GridView1.DataBind();
        }

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Session.Abandon();
    }
}