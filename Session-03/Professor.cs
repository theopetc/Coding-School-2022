using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Professor : Person
    {
        string Rank;
        Course[] Courses = new Course[20];

        public Professor()
        {
            _Name = "Dr." + _Name;
            Rank = "Associate Professor";//Entry level rank
        }

        //SetRank, GetRank wasn't required

        public void Teach(Course course, DateTime datetime)
        {
            Console.WriteLine("Teaches " + course + " at " + datetime);
        }

        public void SetGrade(Guid studentID, Guid courseID, int grade)
        {

        }

        //override
        public new string GetName()
        {
            return _Name;
        }
    }
}
