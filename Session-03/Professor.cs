using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    public class Professor : Person
    {
        public string Rank { get; set; }
        public List<Course> Courses { get; set; }        

        public Professor()
        {
            Rank = "Associate Professor";//Entry level rank
        }

        public void Teach(Course course, DateTime datetime)
        {
            Console.WriteLine("Teaches " + course + " at " + datetime);
        }

        public void SetGrade(Student student, Course course, int grade)
        {
            //int index = student.Courses.IndexOf(course);
            //student.Courses[index] = course;
        }
        //public void SetGrade(Guid studentID, Guid courseID, int grade)
        //{

        //}
    }
}
