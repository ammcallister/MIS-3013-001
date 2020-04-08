using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_2_Toys_Alex_McAllister
{
    class Toy
    {
        public string Manufacturer { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        private string Aisle;

        public Toy ()
        {
            Manufacturer = "";
            Name = "";
            Price = 0;
            Aisle = "";
        }

        public string GetAisle()
        {
            Random rand = new Random();
            int randNumb = rand.Next(1, 25);
            return Manufacturer[1].ToString().ToUpper() + randNumb;
        }


    }
}
