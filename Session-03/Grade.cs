using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Grade
    {
        Guid ID = Guid.NewGuid();
        Guid StudentID = new Guid();
        Guid CourseID = new Guid();
        int _Grade;

        //Grade should only be changed by a professor
        public Grade()
        {
           
        }
    }
}
