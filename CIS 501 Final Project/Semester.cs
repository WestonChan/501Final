﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS_501_Final_Project
{
    using System.Collections;
    class Semester
    {
        public string Name;
        public int Year;
        public ArrayList Sections = new ArrayList();

        public Semester(string Name, int Year)
        {
            this.Name = Name;
            this.Year = Year;
        }

        public bool Equals(Semester other)
        {
            return Name.Equals(other.Name) && Year == other.Year;
        }
    }
}
