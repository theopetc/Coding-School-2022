using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class University : Institute
    {
        Student[] Students = new Student[30];
        Course[] Courses = new Course[20];
        Grade[] Grades = new Grade[20*30];//Total university grades
        Schedule[] ScheduledCourse = new Schedule[60];

        public University()
        {

        }

        public Student[] GetStudents()
        {
            return Students;
        }

        public Course[] GetCourses()
        {
            return Courses;
        }
        
        public Grade[] GetGrades()
        {
            return Grades;
        }

        public void SetSchedule(Guid courseID, Guid ProfessorID, DateTime datetime)
        {

        }
    }
}
