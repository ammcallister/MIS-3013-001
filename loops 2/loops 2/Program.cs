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
            
            double sum = 0;
            string answer;
            
            do

            {
                Console.WriteLine("please give us a # to >>");
                int number = Convert.ToInt32(Console.ReadLine());
                //sum = sum + number; is same as 
                sum += number;
                }
            while (true);
                                    
            Console.ReadKey();

            }
    }
}
