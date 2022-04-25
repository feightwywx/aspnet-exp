using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 课堂练习1
{
    public partial class ConfirmPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string ip = Request.UserHostAddress;
            string name = ((TextBox)PreviousPage.FindControl("TextBox1")).Text;
            string password = ((TextBox)PreviousPage.FindControl("TextBox2")).Text;
            string question = ((DropDownList)PreviousPage.FindControl("DropDownList1")).SelectedValue;
            string answer = ((TextBox)PreviousPage.FindControl("TextBox3")).Text;

            Label1.Text = $"{ip}から、こんにちは！";

            Label3.Text = $"以下是您提交的信息，请确认！<br/><br/>" +
                $"用户名：{name}<br/>" +
                $"密码：{password}<br/>" +
                $"安全提示问题：{question}<br/>" +
                $"安全回答：{answer}";

        }
    }
}