using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ActionResolver a = new ActionResolver();
            ActionRequest request = new ActionRequest();
            ActionResponse response = new ActionResponse();

            Console.Write("Choose Convert, Uppercase or Reverse: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "Convert":
                    request.Action = ActionEnum.Convert;
                    response = a.Execute(request);
                    Console.WriteLine(response.Output);
                    break;
                case "Uppercase":
                    request.Action = ActionEnum.Uppercase;
                    response = a.Execute(request);
                    Console.WriteLine(response.Output);
                    break;
                case "Reverse":
                    request.Action = ActionEnum.Reverse;
                    response = a.Execute(request);
                    Console.WriteLine(response.Output);
                    break;
                default:
                    throw new Exception();
            }

            Console.ReadLine();
        }
    }
}
