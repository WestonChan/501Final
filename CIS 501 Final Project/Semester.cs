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
        public Section Sect;
        public ArrayList Sections = new ArrayList();

        public Semester(string Name, int Year, Section Sect)
        {
            this.Name = Name;
            this.Year = Year;
            this.Sect = Sect;
        }
    }
}
