using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS_501_Final_Project
{
    class Section
    {
        public string SectionNumber;
        public string Consent;
        public int EnrlCap;
        public string TopicDescr;
        public string MeetingStartDt;
        public string MeetingEndDt;
        public string MeetingTimeStart;
        public string MeetingTimeEnd;
        public bool[] Days;
        public int UnitsMin;
        public int UnitsMax;
        public string ClassAssnComponent;

        public Instructor Teach;
        public Facility Place;
        public Semester Sem;
        public Course Cor;

        public Section(string SectionNumber, string Consent, int EnrlCap, string TopicDescr, string MeetingStartDt,
            string MeetingEndDt, string MeetingTimeStart, string MeetingTimeEnd, bool[] Days, int UnitsMin,
            int UnitsMax, string ClassAssnComponent, Instructor Teach, Facility Place, Semester Sem, Course Cor)
        {
            this.SectionNumber = SectionNumber;
            this.Consent = Consent;
            this.EnrlCap = EnrlCap;
            this.TopicDescr = TopicDescr;
            this.MeetingStartDt = MeetingStartDt;
            this.MeetingEndDt = MeetingEndDt;
            this.MeetingTimeStart = MeetingTimeStart;
            this.MeetingTimeEnd = MeetingTimeEnd;
            this.Days = Days;
            this.UnitsMin = UnitsMin;
            this.UnitsMax = UnitsMax;
            this.ClassAssnComponent = ClassAssnComponent;

            this.Teach = Teach;
            this.Place = Place;
            this.Sem = Sem;
            this.Cor = Cor;

            Teach.Sections.Add(this);
            Place.Sections.Add(this);
            Sem.Schedule.Add(this);
            Cor.Sections.Add(this);
        }

        public bool Equals(Section other)
        {
            return Cor.Equals(other.Cor) && SectionNumber.Equals(other.SectionNumber) && Consent.Equals(other.Consent) &&
                EnrlCap == other.EnrlCap && TopicDescr.Equals(other.TopicDescr) && MeetingStartDt.Equals(other.MeetingStartDt) &&
                MeetingEndDt.Equals(other.MeetingEndDt) && MeetingTimeStart.Equals(other.MeetingTimeStart) &&
                MeetingTimeEnd.Equals(other.MeetingTimeEnd) && Enumerable.SequenceEqual(Days, other.Days) && UnitsMin == other.UnitsMin &&
                UnitsMax == other.UnitsMax && ClassAssnComponent.Equals(other.ClassAssnComponent) && Teach.Equals(other.Teach) &&
                Place.Equals(other.Place) && Sem.Equals(other.Sem);
        }

        public override string ToString()
        {
            return "Section " + Cor.ToString() + " Section " + SectionNumber;
        }
    }
}
