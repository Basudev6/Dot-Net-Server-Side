using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            int num = Convert.ToInt32(value1.Text);
            if (num % 2 == 0)
            {
                Response.Write("<script>alert('even number')</script");
            }
            else
            {
                Response.Write("<script>alert ('odd number')</script");
            }
        }
    }
}