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

            ArrayList equalSections = new ArrayList();
            foreach (Section s1 in local.Schedule)
                foreach (Section s2 in ksis.Schedule)
                    if (!s1.Equals(s2)) equalSections.Add(s1);

            return output;
        }
    }
}
