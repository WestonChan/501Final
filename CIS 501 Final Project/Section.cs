using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS_501_Final_Project
{
    class Section
    {
        string SectionNumber;
        string Consent;
        int EnrlCap;
        string TopicDescr;
        string MeetingStartDt;
        string MeetingEndDt;
        string MeetingTimeStart;
        string MeetingTimeEnd;
        bool[] Days = new bool [7];
        int UnitsMin;
        int UnitsMax;
        string ClassAssnComponent;
    }
}
