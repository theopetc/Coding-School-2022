using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Institute
    {
        Guid ID;
        string _Name;
        int YearsInService;

        public Institute()
        {
            ID = Guid.NewGuid();
        }

        public string GetName()
        {
            return _Name;
        }

        public void SetName(string Name)
        {
            _Name = Name;   
        }
    }
}
