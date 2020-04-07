using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Participation
{
    class Program
    {
        static void Main(string[] args)
        {

            TextBox TB1 = new TextBox();
            TB1.Padding = 5;
            TB1.Text = "Hello, This is the first textbox";
            TB1.BackColor = ConsoleColor.Blue;
            TB1.ForeColor = ConsoleColor.Red;

            TB1.DisplayText();

            TextBox TB2 = new TextBox();
            TB2.Padding = 10;
            TB2.Text = "Hello, This is the second textbox with more padding";
            TB2.BackColor = ConsoleColor.Red;
            TB2.ForeColor = ConsoleColor.Cyan;

            TB2.DisplayText();

            Console.ReadKey();

        }
    }
}
