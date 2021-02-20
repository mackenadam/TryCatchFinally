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
            catch (FormatException)
            {
                Console.WriteLine("Format exception, please enter a number.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow exception, your number is too large.");
            }

        }
    }
}
