using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participation_Alex_McAllister_Classes_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle R1 = new Rectangle();
            R1.Length = 6;
            R1.Width = 4;

            Rectangle R2 = new Rectangle();
            R2.Length = 9;
            R2.Width = 5;

            Console.WriteLine($"The area of rectangle 1 is {R1.CalculateArea()} and the perimeter is {R1.CalculatePerimeter()} " );
            Console.WriteLine($"The area of rectangle 2 is {R2.CalculateArea()} and the perimeter is {R2.CalculatePerimeter()} ");

            Circle C1 = new Circle();
            C1.Radius = 3;

            Circle C2 = new Circle();
            C2.Radius = 7;

            Console.WriteLine($"The area of circle 1 is {C1.CalculateArea()} and the perimeter is {C1.CalculatePerimeter()} ");
            Console.WriteLine($"The area of circle 2 is {C2.CalculateArea()} and the perimeter is {C2.CalculatePerimeter()} ");

            Console.ReadKey();
        }
    }
}
