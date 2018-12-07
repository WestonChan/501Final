using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace CIS_501_Final_Project
{
    class LoadFile : CSV_Operations
    {
        public LoadFile(string filename, out Semester local)
        {
            using (StreamReader sr = new StreamReader(filename))
            {
                string line = sr.ReadLine();
                string[] tokens = line.Split(new char[]{' ', ','});
                Semester newSem = new Semester(tokens[0], Convert.ToInt32(tokens[1]));

                //Get to first line
                line = sr.ReadLine();
                line = sr.ReadLine();

                ArrayList Courses = new ArrayList();
                ArrayList Instructors = new ArrayList();
                ArrayList Facilities = new ArrayList();
                bool exists = false;
                
                while (line != null)
                {
                    //Course
                    tokens = line.Split(',');
                    string Subject = tokens[0];
                    int CatalogNbr = Convert.ToInt32(tokens[1]);
                    string ClassDescr = tokens[2];
                    //Instructor
                    string Instructor = tokens[4] + tokens[5];
                    Instructor = Instructor.Substring(1, Instructor.Length - 2);
                    //Facility
                    string FacilityId = tokens[11];
                    //Section
                    string Section = tokens[3];
                    string Consent = tokens[6];
                    int EnrlCap = Convert.ToInt32(tokens[7]);
                    string TopicDescr = tokens[8];
                    string MeetingStartDt = tokens[9];
                    string MeetingEndDt = tokens[10];
                    string MeetingTimeStart = tokens[12];
                    string MeetingTimeEnd = tokens[13];
                    bool[] Days = new bool[7];
                    for (int i = 0; i < 7; i++)
                        Days[i] = tokens[14 + i][0] == 'Y';
                    int UnitsMin = Convert.ToInt32(tokens[21]);
                    int UnitsMax = Convert.ToInt32(tokens[22]);
                    string ClassAssnComponent = tokens[23];
                    line = sr.ReadLine();

                    Section Sect = new Section(SectionNumber, Consent, EnrlCap, TopicDescr, MeetingStartDt, MeetingEndDt,
                        MeetingTimeStart, MeetingTimeEnd, Days, UnitsMin, UnitsMax, ClassAssnComponent);


                    foreach(Course c in Courses)
                    {
                        if()
                    }
                }
                local = newSem;
            }
        }
    }
}
