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

            ArrayList ChangedSections = new ArrayList();
            foreach (Section s1 in local.Schedule)
                foreach (Section s2 in ksis.Schedule)
                    if (!s1.Equals(s2))
                    {
                        local.Schedule.Remove(s1);
                        ksis.Schedule.Remove(s2);
                    }
                    else if (s1.Cor.Equals(s2.Cor) && s1.SectionNumber.Equals(s2.SectionNumber))
                        output += s1.ToString() + " has been changed!";

            foreach (Section s2 in ksis.Schedule)
                foreach (Section s1 in local.Schedule)
                    if (!s1.Equals(s2))
                    {
                        local.Schedule.Remove(s1);
                        ksis.Schedule.Remove(s2);
                    }
                    else if (s1.Cor.Equals(s2.Cor) && s1.SectionNumber.Equals(s2.SectionNumber))
                        output += s2.ToString() + " has been changed!";

            foreach (Section s in local.Schedule) output += s.ToString() + " is not found in the KSIS file!";
            foreach (Section s in ksis.Schedule) output += s.ToString() + " is not found in the Local file!";

            if (output.Equals("")) output = "Verification Success!";

            return output;
        }
    }
}
