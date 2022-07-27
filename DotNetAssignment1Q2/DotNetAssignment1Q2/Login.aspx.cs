using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DotNetAssignment1Q2
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["logincookie"] != null)
            {
                Response.Redirect("Home.aspx");
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("logincookie");
            cookie["i1"] = TextBox1.Text;
            cookie["i2"] = TextBox2.Text;
            Response.Cookies.Add(cookie);

            Response.Redirect("Home.aspx");


        }
    }
}