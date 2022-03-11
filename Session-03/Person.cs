using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    public class Person
    {
        Guid UniqueID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Person()
        {
            UniqueID = Guid.NewGuid();
        }
    }
}
