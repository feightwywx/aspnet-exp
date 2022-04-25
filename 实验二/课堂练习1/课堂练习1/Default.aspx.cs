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

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Image1.ImageUrl = DropDownList1.SelectedValue;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = $"您选择的头像是：{DropDownList1.SelectedItem}";
        }
    }
}