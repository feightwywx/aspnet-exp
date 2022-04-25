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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int input = Convert.ToInt32(txtInput.Text);
            Label1.Text = "";
            foreach (int i in GetPrimes(input))
            {
                Label1.Text += $"{i}<br/>";
            }
        }

        private List<int> GetPrimes(int max)
        {
            List<int> result = new List<int> ();
            
            for (int i = 0; i < max; i++)
            {
                if (IsPrime(i))
                {
                    result.Add(i);
                }
            }

            return result;
        }

        private bool IsPrime(int n)
        {
            if (n <= 3)
            {
                return n > 1;
            }
            
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
}