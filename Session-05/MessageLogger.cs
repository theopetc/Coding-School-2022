using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class MessageLogger
    {

        public Message[] Messages { get; set; } = new Message[200];

        public MessageLogger()
        {
            for (int i = 0; i < 200; i++)
            {
                Messages[i].MessageContent = "";
            }
        }

        public void ReadAll()
        {
            for (int i = 0; i < 200; i++)
            {
                Console.WriteLine(Messages[i].MessageContent);
            }
        }

        public void Clear()
        {
            for (int i = 0; i < 200; i++)
            {
                Messages[i].MessageContent = String.Empty;
            }
        }

        public void Write(Message message)
        {            
            int i = 0;

            while (!string.IsNullOrEmpty(Messages[i].MessageContent))
            {
                i++;
            }

            Messages[i].MessageContent += message.MessageContent;
        }

    }
}
