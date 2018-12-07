using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CIS_501_Final_Project
{
    class Facility
    {
        public string Building;
        public int Room;
        public ArrayList Sections = new ArrayList();
        private Facility(string Building, int Room)
        {
            this.Building = Building;
            this.Room = Room;
        }
    }
}
