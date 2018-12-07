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
        public ArrayList Sections = new ArrayList();
        public string Name;
        private Instructor(string Name)
        {
            this.Name = Name;
        }
    }
}
