using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    public class Institute
    {
        Guid ID { get; set; }
        public string _Name { get; set; }
        public int YearsInService { get; set; }

        public Institute()
        {
            ID = Guid.NewGuid();
        }
    }
}
