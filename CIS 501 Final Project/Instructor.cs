using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CIS_501_Final_Project
{
    class Instructor
    {
        private string name;
        private ArrayList sections;
        public Instructor(string name)
        {
            this.name = name;
        }
        public string Name { get => name; set => name = value; }
        public ArrayList Sections { get => sections;}

        public void AddSection(Section s)
        {
            Sections.Add(s);
        }
    }
}
