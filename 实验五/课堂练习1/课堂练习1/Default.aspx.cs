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
        static readonly localhost.TrainTimeWebService service = new localhost.TrainTimeWebService();
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] stations = service.getStationName();
            foreach (string each in stations)
            {
                DropDownList1.Items.Add(each);
                DropDownList2.Items.Add(each);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = service.getStationAndTimeByStationName(
                DropDownList1.SelectedValue, DropDownList2.SelectedValue, ""
            );
            GridView1.DataBind();

        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
        }
    }
}