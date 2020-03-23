using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input an animal. Acceptable animals are 'cow' 'cat' and 'dog' >>");
            string animal = Console.ReadLine();

        }



        static string speak(string animal)
        {
            animal.ToLower();
            if (animal== "dog")
            {
                return "bark";
            }
            else if (animal== "cat")
            {
                return "meow";
            }
            else if (animal == "cow")
            {
                return "moo";
            }
            else
            {
                return "dont know that animal, please try again";
            }
                        
        }
    }
}
