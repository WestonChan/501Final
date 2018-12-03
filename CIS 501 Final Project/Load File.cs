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
                line = sr.ReadLine().Split(',');
                line = sr.ReadLine().Split(',');
                while (line != null)
                {
                    string Subject = line[0];
                    int CatalogNbr = Convert.ToInt32(line[1]);
                    string ClassDescr = line[2];
                    string Section = line[3];
                    string Instructor = line[4];
                    string Consent = line[5];
                    int EnrlCap = Convert.ToInt32(line[6]);
                    string TopicDescr = line[7];
                    string MeetingStartDt = line[8];
                    string MeetingEndDt = line[9];
                    string FacilityId = line[10];
                    string MeetingTimeStart = line[11];
                    string MeetingTimeEnd = line[12];
                    char Mon = line[13][0];
                    char Tues = line[14][0];
                    char Wed = line[15][0];
                    char Thurs = line[16][0];
                    char Fri = line[17][0];
                    char Sat = line[18][0];
                    char Sun = line[19][0];
                    int UnitsMin = Convert.ToInt32(line[20]);
                    int UnitsMax = Convert.ToInt32(line[21]);
                    string ClassAssnComponent = line[22];

                    line = sr.ReadLine().Split(',');
                }
            }
        }
    }
}
