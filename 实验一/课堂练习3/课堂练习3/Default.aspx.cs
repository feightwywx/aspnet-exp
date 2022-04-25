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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Student input = new Student(
                nameInput.Text, Convert.ToInt32(scoreInput.Text)
            );

            if (input.Score > 100 || input.Score < 0)
            {
                lblDisplay.Text = "输入的成绩不合法！";
            }
            else
            {
                lblDisplay.Text = $"{input.Name}的成绩{ToRank(input.Score)}！";
            }

        }
        private string ToRank(int score)
        {
            if (score == 100)
            {
                return "是满分也 你是真的🐮";
            }
            else if (score >= 90)
            {
                return "优秀";
            }
            else if (score >= 80)
            {
                return "良好";
            }
            else if (score >= 60)
            {
                return "合格";
            }
            else
            {
                return "不合格";
            }
        }
    }
}