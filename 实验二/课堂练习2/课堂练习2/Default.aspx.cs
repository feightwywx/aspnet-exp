using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 课堂练习2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "";

            Label1.Text = "您投票给了";
           for (int i=0; i < CheckBoxList1.Items.Count; i++)
           {
                if (CheckBoxList1.Items[i].Selected)
                {
                    Label1.Text += CheckBoxList1.Items[i].Text + " ";
                }
           }
           if (Label1.Text == "您投票给了")
            {
                Label1.Text = "您还没有投票！";
            }
        }
    }
}