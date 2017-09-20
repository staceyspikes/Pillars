using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillars
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square1 = new Square("square" , 5);
            square1.GetInfo();
            Console.WriteLine(square1.Area());

            Circle circle1 = new Circle("circle", 10);
            circle1.GetInfo();
            Console.WriteLine(circle1.Area());
        }
    }
}
