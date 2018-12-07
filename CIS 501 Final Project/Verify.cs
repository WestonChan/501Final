using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace CIS_501_Final_Project
{
    class Verify
    {
        Semester local;
        Semester ksis;
        public Verify(Semester local, Semester ksis)
        {
            this.local = local;
            this.ksis = ksis;
        }

        public string Execute()
        {
            string output = "";
            ArrayList newLocal = new ArrayList();
            ArrayList newKSIS = new ArrayList();

            ArrayList equalSections = new ArrayList();
            foreach (Section s1 in local.Sections)
            {
                bool exists = false;
                bool existsSame = false;
                foreach (Section s2 in ksis.Sections)
                    if (s1.Cor.Subject.Equals(s2.Cor.Subject) && s1.Cor.CatalogNbr == s2.Cor.CatalogNbr && s1.SectionNumber.Equals(s2.SectionNumber))
                    {
                        exists = true;
                        if (s1.Equals(s2))
                            existsSame = true;
                    }
                if (!exists) newLocal.Add(s1);
                if(exists && !existsSame) output += "Course " + s1.Cor.ToString() + " Section " + s1.SectionNumber + " has been changed!" + Environment.NewLine;
            }

            foreach (Section s2 in ksis.Sections)
            {
                bool exists = false;
                foreach (Section s1 in local.Sections)
                    if (s1.Cor.Subject.Equals(s2.Cor.Subject) && s1.Cor.CatalogNbr == s2.Cor.CatalogNbr && s1.SectionNumber.Equals(s2.SectionNumber))
                        exists = true;
                if (!exists) newKSIS.Add(s2);
            }


            foreach (Section s in newLocal)
                output += "Course " + s.Cor.ToString() + " Section " + s.SectionNumber + " was not found in the KSIS file!" + Environment.NewLine;

            foreach (Section s in newKSIS)
                output += "Course " + s.Cor.ToString() + " Section " + s.SectionNumber + " was not found in the Local file!" + Environment.NewLine;

            output.Trim();

            if (output.Equals("")) output = "Verification Success!";

            return output;
        }
    }
}
