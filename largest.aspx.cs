using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class largest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(value1.Text);
            int b = Convert.ToInt32(value2.Text);
            int c = Convert.ToInt32(value3.Text);
            if(a>b && a>c)
                Response.Write(a+" is greatest");
            else if(b>a && b>c)
                Response.Write(b+" is greatest");
            else
                Response.Write(c+" is greatest");
        }
    }
}