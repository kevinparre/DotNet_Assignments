using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment2Q1
{
    public partial class Supplier : System.Web.UI.Page
    {
        protected void settodaydatetocompare()
        {
            string defaultdateformat = "DD-MM-YYYY";
            string today = DateTime.Today.ToString(defaultdateformat);
            CompareValidator1.ValueToCompare = today;



        }
        protected void Page_Load(object sender, EventArgs e)
        {
            settodaydatetocompare();
        }

       
        protected void BtnSave_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                
                Label1.Text = "Your Record has been saved Successfully!!";
                Label1.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                
                Label1.Text = "Please Review All the Error Msg";
                Label1.ForeColor = System.Drawing.Color.Red;

            }
        }
    }
}