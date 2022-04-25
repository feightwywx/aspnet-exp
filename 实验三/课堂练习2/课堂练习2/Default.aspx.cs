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
        private static List<User> loginHistory = new List<User>();
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Здравствуйте.你是第一次光临本站！请登录。");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Clear();
            string name = TextBox1.Text;

            foreach(User each in loginHistory)
            {
                if (each.name == name)
                {
                    
                    Response.Write($"{name}你好，欢迎再次光临喵！<br/><br/>" +
                        $"你是第{each.loginCount + 1}次光临本站！<br/><br/>" +
                        $"你上次登录的时间是：{each.lastLogin}");
                    each.login();
                    return;
                }
            }
            loginHistory.Add(new User(name));
            Response.Write("你好，登陆成功！您的个人资料已经被本站偷走了喵！");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
        }
    }
}