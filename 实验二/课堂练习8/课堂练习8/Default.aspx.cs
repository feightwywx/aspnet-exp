using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 课堂练习8
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "";
            if ( RegularExpressionValidator1.IsValid &&
                RegularExpressionValidator2.IsValid &&
                RangeValidator1.IsValid &&
                RequiredFieldValidator1.IsValid &&
                RequiredFieldValidator2.IsValid &&
                RequiredFieldValidator3.IsValid
            )
            {
                Label1.Text = "您的预定已经成功通过";
            }
        }
    }
}