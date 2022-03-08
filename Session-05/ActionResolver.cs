using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class ActionResolver
    {
        public MessageLogger Logger { get; set; }
        public ActionResolver()
        {

        }

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

            if (request.Action == ActionEnum.Uppercase)
            {
                Console.Write("Enter a string: ");
                string input = Console.ReadLine();

                string[] words = input.Split(' ');

                if ((CheckInput(input) != "Integer")  || words.Length >= 2) 
                {
                    msg.MessageContent = "Invalid input";
                    //Logger.Write(msg);
                    WriteMessage(msg);
                }

                string word = string.Empty;
                int i = 0;
                foreach (string s in words)
                {
                    if (s.Length > i)
                    {
                        word = s;
                        i = s.Length;
                    }
                }
                response.Output = "The longest word is " + word.ToUpper();
                
                msg.MessageContent = response.Output;
                //Logger.Write(msg);
                WriteMessage(msg);
            }

            if (request.Action == ActionEnum.Reverse)
            {
                Console.Write("Enter a string: ");
                string input = Console.ReadLine();

                if (CheckInput(input) != "Integer")
                {
                    msg.MessageContent = "Invalid input";
                    WriteMessage(msg);
                }
                int stringLength = input.Length;
                char[] result = new char[stringLength];

                for (int i = 0; i < stringLength; i++)
                {
                    result[i] += input[stringLength - i - 1];
                }

                for (int i = 0; i < stringLength; i++)
                {
                    response.Output += Convert.ToString(result[i]);
                }

                msg.MessageContent = response.Output;               
                WriteMessage(msg);
            }
            
            return response;
        }

        public string CheckInput(string input)
        {
            string result = "String";
            int tryInt;
            if (!string.IsNullOrEmpty(input))
            {
                if (Int32.TryParse(input, out tryInt))
                {
                    result = "Integer";
                }
            }
            else
            {
                Console.WriteLine("Your input is empty");                
            }
            return result;
        }

        private void Exit()
        {
            Console.WriteLine("Your input is invalid!");
            Console.Write("Press any key to exit...");
            Console.ReadLine();
            Environment.Exit(0);
        }

        private void WriteMessage(Message msg)
        {
            try
            {
                //Logger.Write(msg);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.ToString());
            }                
        }
    }
}
