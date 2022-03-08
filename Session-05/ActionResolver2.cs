using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    public MessageLogger Logger = new MessageLogger();

    internal abstract class ActionResolver2
    {
        public ActionResolver()
        {

        }

        public abstract ActionResponse Execute(ActionRequest request)
        {

        }
    }

    internal class Convert : ActionResolver2
    {
        public ActionResponse Execute(ActionRequest request)
        {
            var response = new ActionResponse();
            Message msg = new Message();

            if (request.Action == ActionEnum.Convert)
            {               
                Console.Write("Enter an integer: ");
                string input = Console.ReadLine();
                if (CheckInput(input) != "Integer") 
                {
                    msg.MessageContent = "Invalid input";
                    WriteMessage(msg);
                }

                int number = Convert.ToInt32(input);

                response.Output = "The number you entered is " + Convert.ToString(number, 2) + " in binary";
                
                msg.MessageContent = response.Output;
                WriteMessage(msg);
            }
        }
    }

    internal class Uppercase : ActionResolver2
    {
        
    }

    internal class Reverse : ActionResolver2
    {
        
    }
}
