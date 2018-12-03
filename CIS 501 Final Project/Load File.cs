using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CIS_501_Final_Project
{
    class Load_File : CSV_Operations
    {
        public Load_File(string filename)
        {
            Execute(filename);
        }
        private void Execute(string s)
        {
            using (StreamReader sr = new StreamReader(s))
            {
                string[] line = sr.ReadLine().Split(',');
                while (line != null)
                {
                    line = sr.ReadLine().Split(',');

                }
            }
        }
    }
}
