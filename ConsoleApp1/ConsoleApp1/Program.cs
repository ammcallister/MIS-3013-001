//Loop notes Alex McAllister
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();


            int rnd = 3;
            int userInput = 0;

            string result;
            string winFail;

            

           
            while (userInput != rnd) 
            
            {

               
                rnd = rand.Next(0, 2);

                Console.WriteLine("Heads or tails? >>");

                String headsOrTails = Console.ReadLine();

                //IF STATEMENT TO ASSIGN USER INPUT STRING TO AN INT OF 1 OR 2_______________________________________________
                if (headsOrTails == "heads")
                {
                    userInput = 0;
                }
                else
                {
                    userInput = 1;
                }
                //IF TO FIND WHAT THE RESULTS WERE BASED ON THE RAND_______________________________________________
                if (rnd == 0)
                {
                    result = "heads";
                }
                else
                {
                    result = "tails";
                }
                //IF TO SEE IF RESULTS MATCH INPUT_______________________________________________
                if (userInput == rnd)
                {
                    winFail = "Congrats! you won!";
                }
                else
                {
                    winFail = "Sorry, you lost. Guess again...";
                }


                Console.WriteLine("You chose " + headsOrTails + " The value was " + result);
                

                Console.WriteLine(winFail);
                
            }
           
            

            Console.ReadKey();
        }
    }
}
