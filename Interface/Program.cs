using InterfaceClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program

    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(10);
            c1.CalculateArea();
            Console.WriteLine(c1);

            Rectangle rect = new Rectangle(5, 6);
            rect.CalculateArea();
            Console.WriteLine(rect);
        }
    }
}
