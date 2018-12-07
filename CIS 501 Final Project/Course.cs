using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CIS_501_Final_Project
{
    class Course
    {
        public string Subject;
        public int CatalogNbr;
        public string ClassDescr;
        public ArrayList Sections = new ArrayList();

        public Course(string Subject, int CatalogNbr, string ClassDescr)
        {
            this.Subject = Subject;
            this.CatalogNbr = CatalogNbr;
            this.ClassDescr = ClassDescr;
        }

        public bool Equals(Course other)
        {
            return Subject == other.Subject && CatalogNbr == other.CatalogNbr && ClassDescr == other.ClassDescr;
        }

        public override string ToString()
        {
            return Subject + " " + CatalogNbr;
        }
    }
}
