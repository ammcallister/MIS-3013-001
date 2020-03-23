//complex variable and string manipulation
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //                  0123    A is at position 0
            //string firstName = "Alex";
            //string lastName = "McAllister";

            //Console.WriteLine($"You have {firstName.Length.ToString("N0")} characters in your first name." );
            //Console.WriteLine($"You have {lastName.Length.ToString("N0")} characters in your last name.");


            //char firstInitial = firstName[0];
            //char lastInitial = lastName[0];

            //Console.WriteLine($"Your initials are {firstInitial}.{lastInitial}");

            //Console.ReadKey();

            string firstName;
            string lastName;
            string fName;
            Console.WriteLine("first name? >>");
            firstName = Console.ReadLine();
            Console.WriteLine("last name? >>");
            lastName = Console.ReadLine();
            fName = firstName +" "+ lastName;

            Console.WriteLine($"you name is {fName}.");

            for (int i = fName.Length - 1; i >= 0 ; i--)
            {
                Console.Write(fName[i]);
                

            }

            Console.ReadKey();

        }
    }
}
