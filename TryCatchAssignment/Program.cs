using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What's your age? ");

            try
            {
                // input to integer
                int age = Convert.ToInt32(Console.ReadLine());

                // check for under age
                if (age <= 0)
                {
                    // Throw argument for zero or negative age
                    throw new ArgumentException("Age cannot be zero or negative.");
                }

                // Calculate the year of birth
                int birthYear = DateTime.Now.Year - age;
                Console.WriteLine($"You were born in {birthYear}.");
            }
            catch (FormatException)
            {
                // Handling exception
                Console.WriteLine("Please enter a valid number for age.");
            }
            catch (ArgumentException ex)
            {
                // Handling exception
                Console.WriteLine(ex.Message);
            }
            catch (Exception) //catches all exceptions
            {
                Console.WriteLine("An error occurred. Please try again.");

            }
            Console.ReadLine();



        }

    }
}

