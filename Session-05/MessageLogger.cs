using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class MessageLogger
    {

        //public Message[] Messages { get; set; } = new Message[200];
        List<Message> Messages = new List<Message>();

        public MessageLogger()
        {
            //for (int i = 0; i < 200; i++)
            //{
            //    Messages[i].MessageContent = "";
            //}
        }

        public void ReadAll()
        {
            foreach (Message m in Messages)
            {
                Console.WriteLine(m.MessageContent);
            }
            //for (int i = 0; i < 200; i++)
            //{
            //    Console.WriteLine(Messages[i].MessageContent);
            //}
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
