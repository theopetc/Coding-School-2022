using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    public class Schedule
    {
        Guid ID { get; set; }
        Guid CourseID { get; set; }
        Guid ProfessorID { get; set; }
        DateTime Callendar { get; set; }

        public Schedule()
        {
            ID = Guid.NewGuid();
        }


    }
}
