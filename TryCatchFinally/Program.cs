using System;

namespace TryCatchFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            string userInput = Console.ReadLine();

            int userInputAsInteger = int.Parse(userInput);
        }
    }
}
