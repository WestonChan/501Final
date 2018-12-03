using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS_501_Final_Project
{
    class Singleton
    {
        private Singleton theInstance;
        private Singleton() { }
        public Singleton instance()
        {
            if(theInstance != null)
                return theInstance;
            return new Singleton();
        }

    }
}
