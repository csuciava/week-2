using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        enum Gender
        {
            Male = 65,
            Female = 63
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Enter a year:");
            int year;
            if (int.TryParse(Console.ReadLine(), out year) == false)
            {
                Console.WriteLine("Only numbers");
            };

            Console.WriteLine("Enter a month:");
            int month;
            if (int.TryParse(Console.ReadLine(), out month)==false)
            {
                Console.WriteLine("Only numbers");
            };

            Console.WriteLine("Enter a day:");
            int day;
            if (int.TryParse(Console.ReadLine(), out day) == false)
            {
                Console.WriteLine("Only numbers");
            };

            DateTime birthday = new DateTime(year, month, day);
            TimeSpan difInDays = DateTime.Today - birthday;
            int age = (new DateTime(1, 1, 1) + difInDays).Year -1;

            int? gender = null;
            Console.WriteLine("Enter the gender (M/F): ");
            string c = Console.ReadLine();

            if(c == "M" || c == "m")
            {
                gender = (int) Gender.Male;
            } else if(c == "F"|| c=="f")
            {
                gender = (int) Gender.Female;
            }

            if(gender != null)
            {
                Console.WriteLine("Retirement age: " + gender);
                Console.WriteLine("Current age: " + age + " " + ((gender - age < 20) ? "Close :)":"Still young"));
            }

            Console.ReadKey();
        }

    }
}
