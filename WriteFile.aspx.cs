using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace WebApplication1
{
    public partial class WriteFile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnwrite_Click(object sender, EventArgs e)
        {
            File.WriteAllText(Server.MapPath("indreni.txt"), txtContent.Text);
          
        }
    }
}