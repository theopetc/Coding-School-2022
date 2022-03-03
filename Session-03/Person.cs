using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Person
    {
        Guid _UniqueID;
        public string _Name;
        ushort _Age;

        public Person()
        {
            _UniqueID = Guid.NewGuid();
        }

        public string GetName() 
        { 
            return _Name;
        }

        public void SetName(string name)
        {
            _Name = name;
        }


       
    }
}
