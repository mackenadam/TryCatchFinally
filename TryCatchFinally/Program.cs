using System;

namespace TryCatchFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            string userInput = Console.ReadLine();

            try
            {
                int userInputAsInteger = int.Parse(userInput);
                Console.WriteLine("You entered {0}", userInputAsInteger);
            }
            catch (Exception)
            {
                Console.WriteLine("Format exception, please enter a number.");
            }

        }
    }
}
