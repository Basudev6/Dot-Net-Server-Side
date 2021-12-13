using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class exception_handeling : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {

                int a = Convert.ToInt32(value1.Text);
                int b = Convert.ToInt32(value2.Text);
                int c = a / b;
                Response.Write("Division is " + c);
            }
            catch(Exception ex)
            {
                Response.Write("Error occured! Reason is " + ex.Message);
            }

        }
    }
}