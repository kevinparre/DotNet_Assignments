using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace hiddenex
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn1_Click(object sender, EventArgs e)
        {
            HiddenField1.Value = TextBox1.Text;
            HiddenField2.Value = TextBox2.Text;
            TextBox1.Text = String.Empty;
            TextBox2.Text = String.Empty;

        }

        protected void Btn2_Click(object sender, EventArgs e)
        {
            Label3.Text = HiddenField1.Value + "and password is" + HiddenField2.Value;

        }
    }
}