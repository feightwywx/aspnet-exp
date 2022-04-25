using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 课堂练习5
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            
            var newValues = e.NewValues;
            var ID = e.Keys["ID"];
            SqlDataSource1.UpdateCommand = $"UPDATE GuestBookInfo " +
                            $"SET Name='{newValues["Name"]}'," +
                            $"Detail='{newValues["Detail"]}'," +
                            $"Time='{newValues["Time"]}'," +
                            $"Back='{newValues["Back"]}' " +
                            $"WHERE ID={ID}";
        }
    }
}