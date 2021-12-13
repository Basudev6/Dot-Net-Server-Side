using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class session_login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            if(txtuser.Text=="admin" && txtpwd.Text=="admin")
            {
                Session["islogin"] = true;
                Response.Redirect("session_welcome.aspx");
            }
            else
            {
                Response.Write("Invalid username or password");
            }
        }
    }
}