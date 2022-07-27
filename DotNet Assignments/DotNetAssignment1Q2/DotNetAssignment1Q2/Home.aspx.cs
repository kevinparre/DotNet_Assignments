using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DotNetAssignment1Q2
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (PreviousPage != null && PreviousPage.IsCrossPagePostBack)
            {
                TextBox username = (TextBox)PreviousPage.FindControl("TextBox1");
                TextBox password = (TextBox)PreviousPage.FindControl("TextBox2");

                HttpCookie cookie = new HttpCookie("logincookie");
                cookie["i1"] = username.Text;
                cookie["i2"] = password.Text;
                Response.Cookies.Add(cookie);
                


                //HttpCookie rc = Request.Cookies["logincookie"];
                //Label1.Text = rc["i1"];

                Label1.Text = "Welcome!!!!" + username.Text + " and Your Password is :" + password.Text;
            }

            else if (Request.Cookies["logincookie"] != null)
            {
                HttpCookie rc = Request.Cookies["logincookie"];
                Label1.Text = "Welcome " + rc["i1"] + "  " + "and  Your password is: " + rc["i2"];
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }
protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie rc = Request.Cookies["logincookie"];
            rc.Expires = DateTime.Now.AddDays(-1);
            Response.Redirect("Login.aspx");
            
        }
    }
}