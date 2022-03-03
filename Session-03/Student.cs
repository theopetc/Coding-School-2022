using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Student
    {
        int RegistrationNumber;
        Course[] Courses = new Course[20];

        public Student()
        {
            RegistrationNumber = 0;
        }

        public void Attend(Course course, DateTime dateTime)
        {
            Console.WriteLine("Attends " + course + " at " + dateTime);
        }

        public void WriteExam(Course course, DateTime dateTime)
        {
            Console.WriteLine("Writes " + course + " at " + dateTime);
        }


    }
}
