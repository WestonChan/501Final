using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS_501_Final_Project
{
    class Presenter
    {
        public void executeLoad(string filename)
        {
            Load_File f = new Load_File(filename);
        }
    }
}
