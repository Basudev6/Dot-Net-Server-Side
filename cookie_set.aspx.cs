using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class cookie_set : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie obj= new HttpCookie("name");
            obj.Value = txtname.Text;
            obj.Expires = DateTime.Now.AddMinutes(2);
            Response.Cookies.Add(obj);
        }
    }
}  