using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 课堂练习4
{
    public partial class Desktop : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            for (int i = 2022; i > 1900; i--)
            {
                DropDownList1.Items.Add(new ListItem(i.ToString(), i.ToString()));
            }

            for (int i = 1; i <= 12; i++)
            {
                DropDownList2.Items.Add(new ListItem(i.ToString(), i.ToString()));
            }
        }
        private static string LastUpload { get; set; }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Image1.ImageUrl = LastUpload;
            Image2.ImageUrl = LastUpload;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string virpath = "~/images/" + FileUpload1.FileName;
                LastUpload = virpath;
                string mappath = Server.MapPath(virpath);
                FileUpload1.PostedFile.SaveAs(mappath);
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Panel2.Visible = true;
            Panel1.Visible = false;
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Table1.Rows[0].Cells[1].Text = TextBox1.Text;
            Table1.Rows[1].Cells[1].Text = RadioButtonList1.SelectedItem.Text;
            Table1.Rows[2].Cells[1].Text = $"{DropDownList1.SelectedValue}年{DropDownList2.SelectedValue}月";
            Table1.Rows[3].Cells[1].Text = "";
            for (int i = 0; i < CheckBoxList1.Items.Count; i++)
            {
                if (CheckBoxList1.Items[i].Selected) Table1.Rows[3].Cells[1].Text += CheckBoxList1.Items[i].Value;
            }

            Panel1.Visible = true;
            Panel2.Visible = false;
        }
    }
}