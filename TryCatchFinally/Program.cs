using System;

namespace TryCatchFinally
{
    class Program
    {
        static void Main(string[] args)
        {    
            // Challenge
            try
            {
                int zero = 0;
                int five = 5;
                int impossibleNumber = five / zero;
                Console.WriteLine("Congratulations, you clocked math. The impossible number is {0}", impossibleNumber);
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Sorry, but that would break everything...");
            }
            finally
            {
                Console.WriteLine("Of course it didn't work.");
            }

            try
            {
                int userInputAsInteger = int.Parse(GetUserInput());
                Console.WriteLine("You have entered: {0}", userInputAsInteger);
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

        public static string GetUserInput()
        {
            Console.WriteLine("Please enter a number:");
            string consoleInput = Console.ReadLine();
            return consoleInput;
        }
    }
}
