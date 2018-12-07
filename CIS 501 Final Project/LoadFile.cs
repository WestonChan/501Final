using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CIS_501_Final_Project
{
    class LoadFile
    {
        public LoadFile(string filename, out Semester local)
        {
            using (StreamReader sr = new StreamReader(filename))
            {
                string line = sr.ReadLine();
                line = sr.ReadLine();
                line = sr.ReadLine();
                while (line != null)
                {
                    string[] tokens = line.Split(',');
                    string Subject = tokens[0];
                    int CatalogNbr = Convert.ToInt32(tokens[1]);
                    string ClassDescr = tokens[2];
                    string Section = tokens[3];
                    string Instructor = tokens[4] + tokens[5];
                    string Consent = tokens[6];
                    int EnrlCap = Convert.ToInt32(tokens[7]);
                    string TopicDescr = tokens[8];
                    string MeetingStartDt = tokens[9];
                    string MeetingEndDt = tokens[10];
                    string FacilityId = tokens[11];
                    string MeetingTimeStart = tokens[12];
                    string MeetingTimeEnd = tokens[13];
                    char Mon = tokens[14][0];
                    char Tues = tokens[15][0];
                    char Wed = tokens[16][0];
                    char Thurs = tokens[17][0];
                    char Fri = tokens[18][0];
                    char Sat = tokens[19][0];
                    char Sun = tokens[20][0];
                    int UnitsMin = Convert.ToInt32(tokens[21]);
                    int UnitsMax = Convert.ToInt32(tokens[22]);
                    string ClassAssnComponent = tokens[23];
                    line = sr.ReadLine();
                }
            }
            //local = created Semester
            local = null;
        }
    }
}
