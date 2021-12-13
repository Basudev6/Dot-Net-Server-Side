using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class cookie_read : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["name"] != null)
            {
                lblname.Text = Request.Cookies["name"].Value;
            }
            else
            {
                lblname.Text = "Guest";
            }
        }
    }
}