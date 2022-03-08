using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class Message
    {
        public Guid ID { get; set; }
        public DateTime TimeStamp { get; set; }
        public string MessageContent { get; set; }

        public Message()
        {
            //init guid and timestamp
            ID = Guid.NewGuid();
            TimeStamp = DateTime.Now;

        }


    }
}
