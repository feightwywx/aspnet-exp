using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 课堂练习3
{
    public partial class Default : System.Web.UI.Page
    {
        private static bool isVoted = false;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!isVoted)
            {
                Response.Write("<script language=javascript>alert('投票成功，谢谢您的参与！');</script>");
                isVoted = true;
            }
            else
            {
                Response.Write("<script language=javascript>alert('您只能投一次票，谢谢您的参与！');</script>");
            }
        }
    }
}