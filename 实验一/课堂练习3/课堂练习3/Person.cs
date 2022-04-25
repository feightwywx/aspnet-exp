using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace 课堂练习3
{
    public class Person
    {
        private string name;
        private int score;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Score
        {
            get { return score; }
            set { score = value; }
        }
        public Person(string name, int score)
        {
            this.Name = name;
            this.Score = score;
        }
    }
}