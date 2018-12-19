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
            Male = 0,
            Female = 1
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
            TimeSpan age = DateTime.Today - birthday;
            Console.WriteLine("Age is: " + ((new DateTime(1, 1, 1) +age).Year -1));

            Console.ReadKey();
        }

    }
}
