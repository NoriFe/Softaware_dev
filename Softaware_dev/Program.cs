using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softaware_dev
{
    internal class Program
    {
        static void Main(string[] args)
        {   // creating menu for user with 2 options and exit
            int option;

            do
            {
                Console.WriteLine("Pick an option:");
                Console.WriteLine("1. Create username");
                Console.WriteLine("2. Calculate Factorial");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your option: ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        string forename = getforename();
                        string surname = getsurname();
                        create_username(forename, surname);
                        break;
                    case 2:
                        
                        break;
                    case 3:
                        Console.WriteLine("See ya later aligator!");
                        break;
                    default:
                        Console.WriteLine("Invalid option! Try agian :)");
                        break;
                }

            }
            while (option != 3);
        }

        // function to get the forename and surname from the user
        static string getforename()
        {
            Console.Write("Enter your forename: ");
            string forename = Console.ReadLine();
            return forename;
        }
        static string getsurname()
        {
            Console.Write("Enter your surname: ");
            string surname = Console.ReadLine();
            return surname;
        }
        // function to create username from the forename and surname
        static void create_username(string forename, string surname)
        {
            string username = forename[0].ToString().ToLower() + surname.ToUpper();
            Console.WriteLine($"Your username is: {username}");
        }


    }
}
