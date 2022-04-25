using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace 课堂练习2
{
    public class User
    {
        public string name { get; set; }
        public int loginCount { get; set; }
        public DateTime lastLogin { get; set; }

        public User(string name)
        {
            this.name = name;
            this.loginCount = 1;
            this.lastLogin = DateTime.Now;
        }
        public void login()
        {
            loginCount++;
            lastLogin = DateTime.Now;
        }
    }
}