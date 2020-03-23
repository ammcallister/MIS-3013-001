using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm_review
{
    class Program
    {
        static void Main(string[] args)
        {
            int itemPrice = Convert.ToInt32(Console.ReadLine());
            int howManyShouldIBuy;

            if (itemPrice < 10)
            {
                howManyShouldIBuy = 50;
            }
            else if (itemPrice > 10 && itemPrice < 20)
            {
                if (itemPrice == 15)
                {
                    howManyShouldIBuy = 40;
                }
                else if (itemPrice > 15)
                {
                    howManyShouldIBuy = 35;
                }
                else
                {
                    howManyShouldIBuy = 30;
                }
            }
            else
            {
                howManyShouldIBuy = 20;
            }

            Console.WriteLine(howManyShouldIBuy);
            Console.ReadKey();
        }
    }
}
