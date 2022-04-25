using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 课堂练习1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=DIREWOLFC96F;Initial Catalog=GuestBook;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand($"INSERT INTO GuestBookInfo (Name, Detail, Time) VALUES ('{name0.Text}', '{comment0.Text}', '{DateTime.Now}');", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            Response.Write("<script language=javascript>alert('添加留言成功了喵~');</script>");
            name0.Text = "";
            comment0.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            name0.Text = "";
            comment0.Text = "";
        }
    }
}