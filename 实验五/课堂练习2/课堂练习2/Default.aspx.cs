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
        static readonly localhost.WebService service = new localhost.WebService();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox3.Text = service.GetTotal(
                DropDownList1.SelectedValue,
                Convert.ToInt32(TextBox1.Text),
                Convert.ToInt32(TextBox2.Text)
            ).ToString();
        }
    }
}