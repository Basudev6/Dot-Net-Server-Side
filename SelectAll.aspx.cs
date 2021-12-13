using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication1
{
    public partial class ShowAll : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            // database connection
            SqlConnection conn = new SqlConnection("server=DESKTOP-DIF77T7;database=IndreniBCADB;integrated security=true");
            conn.Open();

            // sql code to select
            SqlCommand cmd = new SqlCommand("select * from tbStudent");


            // link database and code
            cmd.Connection = conn;

            // run the sql code in server
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(rdr);

            GridView1.DataSource = dt;
            GridView1.DataBind(); 
        }
    }
}