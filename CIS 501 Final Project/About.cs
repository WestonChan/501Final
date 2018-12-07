using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS_501_Final_Project
{
    class About
    {
        private Version v = new Version();
        public About(out string[] versions)
        {
            versions = new string[] { v.VersionType, v.VersionDate };
        }


    }
}
