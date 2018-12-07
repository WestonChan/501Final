using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace CIS_501_Final_Project
{
    class Load
    {
        string Filename;
        public Load(string Filename)
        {
            this.Filename = Filename;
        }
        public Semester Execute()
        {
            using (StreamReader sr = new StreamReader(Filename))
            {
                string line = sr.ReadLine();
                string[] tokens = line.Split(new char[] { ' ', ',' });
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
                    string InstructorName = tokens[4] + tokens[5];
                    InstructorName = InstructorName.Substring(1, InstructorName.Length - 2);

                    //Facility
                    string Building = "";
                    string Room = "";
                    for (int i = 0; i < tokens[11].Length; i++)
                        if (!Char.IsDigit(tokens[11][i])) Building += tokens[11][i];
                        else if (Room.Equals("") && !tokens[11].Substring(i).Equals(""))
                            Room = tokens[11].Substring(i);

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

                    Course tempCourse = null;
                    Instructor tempInstructor = null;
                    Facility tempFacility = null;

                    //Find the Course indicated from file
                    foreach (Course c in Courses)
                        if (!exists && c.Subject.Equals(Subject) && c.CatalogNbr == CatalogNbr && c.ClassDescr.Equals(ClassDescr)) { exists = true; tempCourse = c; }
                    if (!exists) tempCourse = new Course(Subject, CatalogNbr, ClassDescr);
                    exists = false;

                    //Find the Instructor indicated from file
                    foreach (Instructor i in Instructors)
                        if (!exists && i.Name.Equals(InstructorName)) { exists = true; tempInstructor = i; }
                    if (!exists) tempInstructor = new Instructor(InstructorName);
                    exists = false;

                    //Find the Facility indicated from file
                    foreach (Facility f in Facilities)
                        if (!exists && f.Building.Equals(Building) && f.Room.Equals(Room)) { exists = true; tempFacility = f; }
                    if (!exists) tempFacility = new Facility(Building, Room);

                    //Create a Section
                    Section Sect = new Section(Section, Consent, EnrlCap, TopicDescr, MeetingStartDt, MeetingEndDt,
                        MeetingTimeStart, MeetingTimeEnd, Days, UnitsMin, UnitsMax, ClassAssnComponent, tempInstructor, tempFacility, newSem, tempCourse);
                }
                return newSem;
            }
        }
    }
}
