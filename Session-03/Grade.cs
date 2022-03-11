using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    public class Grade
    {
        Guid ID { get; set; }
        Guid StudentID { get; set; }
        Guid CourseID { get; set; }
        public int GradeValue { get; set; }

        public Grade()
        {
            ID = Guid.NewGuid();
        }
    }
}
