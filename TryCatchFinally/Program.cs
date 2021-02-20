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
                Console.WriteLine("Format exception, please make sure your input is a number.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow exception, your number is too large or too small for an Int32.");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Argument Null exception, make sure you have input a number.");
            }
            finally
            {
                Console.WriteLine("This is called anyway.");
            }

        }
    }
}
