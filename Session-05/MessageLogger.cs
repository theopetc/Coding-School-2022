using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class MessageLogger
    {        
        List<Message> Messages = new List<Message>();

        public MessageLogger()
        {
            
        }

        public void ReadAll()
        {
            foreach (Message m in Messages)
            {
                Console.WriteLine(m.MessageContent);
            }
        }

        public void Clear()
        {
            Messages.Clear();
        }

        public void Write(Message message)
        {            
            Messages.Add(message);
        }

    }
}
