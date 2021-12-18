using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Equation_Line
{
    public class Equation
    {
        public double k;
        public double b;
        public double x;

        public void Root()
        {
            Console.WriteLine("Представлено линейное уравнение 0 = kx + b");
            Console.Write("Введите число k = ");
            k = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите число b = ");
            b = Convert.ToDouble(Console.ReadLine());
            if (b == 0) { Console.WriteLine("Ошибка!"); }
            else { x = -(b / k); }
        }
    }
}
