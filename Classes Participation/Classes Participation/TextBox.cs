﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Participation
{
    class TextBox
    {

        public int Padding { get; set; }

        public ConsoleColor BackColor { get; set; }

        public ConsoleColor ForeColor { get; set; }

        public String Text { get; set; }

        public TextBox()
        {
            Padding = 0;
            BackColor = ConsoleColor.Black;
            ForeColor = ConsoleColor.White;
            Text = "";

        }

        public void DisplayText()
        {
            string space = "";

            Console.ForegroundColor = ForeColor;
            Console.BackgroundColor = BackColor;

            for (int i = 0; i < Padding; i++)
            {
                space = space + " ";

            }

            Console.WriteLine(space+Text+space);
        }
    }
}
