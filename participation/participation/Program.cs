
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace participation
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int rnd = rand.Next(0, 2);
           

            int userInput;

            string result;
            string winFail;

            Console.WriteLine("Heads or tails? >>" );
            
            String headsOrTails = Console.ReadLine();

            

            //...........................
            if (headsOrTails == "heads")
            {
                userInput = 0;
            }
            else
            {
                userInput = 1;
            }

            //...........................

            if (rnd == 0)
           {
                result = "heads";
            }
            else
            {
                result = "tails";
            }
            
            if (userInput ==rnd)
            {
                winFail = "Congrats! you won!";
            }
            else
            {
                winFail = "Sorry, you lost.";
            }


            Console.WriteLine("You chose " + headsOrTails + " The value was " + result);
            Console.WriteLine(winFail);


            Console.ReadKey();


        }
    }
}
