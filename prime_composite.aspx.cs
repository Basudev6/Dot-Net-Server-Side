using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void value1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(value1.Text);
            int i,count = 0;
            for(i=1;i<=num; i++)
            {
                if (num%i==0)
                    count++;
            }
            if (count == 2)
                Response.Write("<script>alert('Prime number')</script>");
            else
                Response.Write("<script>alert('Composite number')</script>");


        }
    }
}