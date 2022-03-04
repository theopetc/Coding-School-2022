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
            Rank = "Associate Professor";//Entry level rank
        }

        public void Teach(Course course, DateTime datetime)
        {
            Console.WriteLine("Teaches " + course + " at " + datetime);
        }

        //private void SetGrade(Student student, Grade student.grade, int grade);
        private void SetGrade(Guid studentID, Guid courseID, int grade)
        {

        }

        //override
        public new string GetName()
        {
            return "Dr." + _Name;
        }
    }
}
