using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;

namespace 课堂练习3
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            if (e.Day.IsWeekend)
            {
                e.Cell.BackColor = System.Drawing.Color.Red;
                e.Cell.Controls.Add(new LiteralControl("<br> 休息天"));
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            DateTime d = Calendar1.SelectedDate;
            Label1.Text = $"您选择的日期是：{d.ToString("yyyy年MM月dd日 dddd", new CultureInfo("zh-CN"))}";
        }
    }
}