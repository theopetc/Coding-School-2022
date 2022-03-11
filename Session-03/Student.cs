using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    public class Student : Person
    {
        public int RegistrationNumber { get; set; }
        public List<Course> Courses = new List<Course>(); 

        public Student()
        {
            Name = String.Empty;
            Age = 0;
            RegistrationNumber = 0;
            //Course c = new Course();
            //c.Subject = "";
            //c.Code = "0";    
            //Courses.Add(c);
        }

        public void Attend(Course course, DateTime dateTime)
        {
            Console.WriteLine("Attends " + course + " at " + dateTime);
        }

        public void WriteExam(Course course, DateTime dateTime)
        {
            Console.WriteLine("Writes " + course + " at " + dateTime);
        }

        public Student ShallowCopy()
        {
            return (Student)MemberwiseClone();
        }


    }

    [Serializable]
    public class StudentList
    {
        public List<Student> Students { get; set; }

        public StudentList()
        {

        }
    }
}
