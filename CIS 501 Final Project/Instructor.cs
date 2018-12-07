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
        public Instructor(string Name)
        {
            this.Name = Name;
        }

        public bool Equals(Instructor other)
        {
            return Name.Equals(other.Name);
        }
    }
}
