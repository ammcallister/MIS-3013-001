//AM
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What number do you want to count up to? >>");
            int threshold = Convert.ToInt32(Console.ReadLine());
            
            
            //could also use < 100 
            for (int i = 1; i <= threshold; i++)
            {
                Console.WriteLine(i + " ");

            }

            Console.ReadKey();


        }
    }
}
