using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 课堂练习7
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private string[] usernames = { "嘉然今天吃什么", "向晚大魔王", "贝拉kira", "珈乐Carol", "乃琳Queen" };

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = !usernames.Contains(args.Value);
        }
    }
}