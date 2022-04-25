using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 课堂练习1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text.Trim();
            string[] bigs = { "1", "3", "5", "7", "8", "10", "12" };
            string[] littles = { "4", "6", "9", "11" };
            
            if (string.IsNullOrEmpty(input))
            {
                lblDisplay.Text = "请输入数字形式的月份";
            }
            else if (bigs.Contains(input))
            {
                lblDisplay.Text = $"{input}月有31天";
            }
            else if (littles.Contains(input))
            {
                lblDisplay.Text = $"{input}月有30天";
            }
            else if (input == "2")
            {
                lblDisplay.Text = "2月有28或29天";
            }
            else
            {
                lblDisplay.Text = "输入的数值不是数字形式的月份！";
            }
        }
    }
}