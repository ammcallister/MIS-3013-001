//Alex McAllister
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_example
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an string named firstName
            string firstName;

            // Assign a value to firstName (your name)
            firstName = "Alex";

            //Create an int named favoriteNumber and assign your favorite number to it
            int favoriteNumber = 27;

            double crazyNumber = 7.6767 * favoriteNumber;

            string lastName = "McAllister";

            string fullName = firstName + " " + lastName;



            Console.WriteLine(fullName + " has the favorite number of " + favoriteNumber
                                + "\nwhich equates to a crazy number of " + crazyNumber);


            // MAKE IT DYNAMIC
            Console.WriteLine("Please enter your first name: >>");
            firstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name: >>");
            lastName = Console.ReadLine();

            Console.WriteLine("Please enter your favoirte number: >>");
            string favoriteNumberAsString = Console.ReadLine();
            favoriteNumber = Convert.ToInt32(favoriteNumberAsString);

            fullName = firstName + " " + lastName;
            //favoriteNumber = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(fullName + " has the favorite number of " + favoriteNumber
                              + "\nwhich equates to a crazy number of " + crazyNumber);

            //Console.WriteLine($"{fullName} has the favorite number of {favoriteNumber} \nwhich equates to a crazy number of {crazyNumber}");

            Console.ReadKey();
         
        }
    }
}
