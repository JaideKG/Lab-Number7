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
