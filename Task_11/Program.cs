using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Equation_Line;

namespace Task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Equation Line = new Equation();
            Line.Root();
            Console.WriteLine("Число x = " + Line.x);
            Console.ReadKey();
        }
    }
}
