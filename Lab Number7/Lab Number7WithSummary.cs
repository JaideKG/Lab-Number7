using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab_Number7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lesson Summary
            //During Monday’s class of April 30th, 2018 we went over exceptions, validation, regular expressions, debugging & testing and  lab 7.
            //When working on circuit evaluations, I learned that both sides of an if statement is evaluated.
            //Discussed also was De Morgan’s Law which identifies characters as short circuit evaluations, ie., the double ampersand(&&), and the or double bar(||).
            //Considered during class was combinatoric explosion, which explained the testing of every possible combination within a code.
            //Also discussed were short term – long term memory concepts such as recalling, organizing, integrating, and elaborating.

            //During class, we also went over regex expressions and characters.
            //Some of the main characters used are \w – words, \W-no words, \d - digits, \D - no digits, [] - any, \b – boundary, \B – no boundary. 
            //By using the regexr website, expressions could be tested before adding to Visual Studio.In visual studio, the slash (/) is read as an escape character.
            //Using a double slash(//) helps this to be recognized as a single /. 
            //During class, I learned how to validate names, emails, telephone numbers, and dates.    

         bool Y = true;

            while (Y)
            {
                bool ValidName;
                Console.WriteLine("Greetings! Please enter a Name.");
                string Name = Console.ReadLine();

                ValidName = Regex.IsMatch(Name, "[A-Z]{1}[a-z]{2,30}");

                if (ValidName)
                {
                    Console.WriteLine("Thank you! You have entered a valid name.");
                }
                else
                {
                    Console.WriteLine("Sorry, you have entered an invalid name.");
                }
                bool ValidEmail;
                Console.WriteLine("Please enter a valid email.");
                string Email = Console.ReadLine();

                ValidEmail = Regex.IsMatch(Email, "^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$");
                if (ValidEmail)
                {
                    Console.WriteLine("Thank you! You have entered a valid email.");
                }
                else
                {
                    Console.WriteLine("Sorry, the email you entered is invalid.");
                }
                bool ValidNumber;
                Console.WriteLine("Please enter a valid telephone number.");
                string Number = Console.ReadLine();

                ValidNumber = Regex.IsMatch(Number, "^[0-9]{3}-[0-9]{3}-[0-9]{4}$");
                if (ValidNumber)
                {
                    Console.WriteLine("Thank you! You have entered a valid telephone number.");
                }
                else
                {
                    Console.WriteLine("Sorry, the telephone number you entered is not valid.");
                }
                bool ValidDate;
                Console.WriteLine("Please enter a valid date.");
                string Date = Console.ReadLine();

                ValidDate = Regex.IsMatch(Date, "[0-9]{2}/[0-9]{2}/[0-9]{4}$");
                if (ValidDate)
                {
                    Console.WriteLine("Thank you! You have entered a valid date.");
                }
                else
                {
                    Console.WriteLine("Sorry, the date entered is not valid.");
                }
                Console.Write("Press Y key to continue or 'N' to abort:");
                if (Console.ReadKey().Key == ConsoleKey.N)
                    return;
                {

                }

            }
        }
    }
}
