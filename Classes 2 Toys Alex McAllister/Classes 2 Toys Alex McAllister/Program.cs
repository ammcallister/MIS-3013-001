using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_2_Toys_Alex_McAllister
{
    class Program
    {
        static void Main(string[] args)
        {

            Toy t1 = new Toy();
            t1.Manufacturer = "Mattel";
            t1.Name = "Uno";
            t1.Price = 5.99;

            Toy t2 = new Toy();
            t1.Manufacturer = "Hasbro";
            t1.Name = "Monopoly";
            t1.Price = 14.99;

            List<Toy> TB1 = new List<Toy>();
            TB1.Add(t1);
            TB1.Add(t2);


            string cont = "Y";
            List<Toy> TB2 = new List<Toy>();
            do
            {


                Console.WriteLine("Please add a toy to your toybox. First, what is the manufacturer? >>");
                Toy TY = new Toy();
                TY.Manufacturer = Console.ReadLine();
                Console.WriteLine("Next the name of the toy>>");
                TY.Name = Console.ReadLine();
                Console.WriteLine("Lastly the price of the toy>>");
                TY.Price = Convert.ToDouble(Console.ReadLine());
                TB2.Add(TY);

                Console.WriteLine("Would you like to add another toy to your toybox? Please input Y or N >>");
                cont = Console.ReadLine().ToUpper();

            } while (cont == "Y");


            Console.WriteLine("The following toys are in your toybox");
            for (int i = 0; i < TB2.Count; i++)
            {
                Console.WriteLine($"{TB2[0].Name}");
                
            }
            Console.ReadKey();
        }
    }
}
