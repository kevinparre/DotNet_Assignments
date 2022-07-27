using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment1
{
    public partial class Store : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                String[] str = new string[] { "Select", "Macbook", "Dell", "Acer", "HP" };
                for( int i=0; i < str.Length; i++)
                {
                    DropDownList1.Items.Add(str[i]);
                }

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = DropDownList1.SelectedIndex.ToString();
            if(DropDownList1.Text == "Macbook")
            {
                Label1.Text = "The Price is : Rs:111000";

            }
            else if (DropDownList1.Text == "Dell")
            {
                Label1.Text = "The Price is : Rs:89000";

            }

            else if (DropDownList1.Text == "Acer")
            {
                Label1.Text = "The Price is : Rs:52000";

            }
            else if (DropDownList1.Text == "HP")
            {
                Label1.Text = "The Price is : Rs:69000";

            }

            else
            {
                Label1.Text = "";
            }


        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = DropDownList1.Text;
            Image1.ImageUrl = "~/images/" + str + ".jpg";
        }
    }
}