using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    public class Course
    {
        public Guid ID { get; set; }
        public string Code { get; set; }
        public string Subject { get; set; }

        public Course()
        {
            Code = "00";
            Subject = "";

            ID = Guid.NewGuid();    
        }


    }
}
