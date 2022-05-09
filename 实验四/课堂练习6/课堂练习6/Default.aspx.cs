using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 课堂练习6
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            var ID = e.Keys["ID"];
            SqlDataSource1.DeleteCommand = $"DELETE FROM GuestBookInfo WHERE ID='{ID}';";
        }
    }
}