using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillars
{
    class Circle : IShape
    {
        public string Name { get; set; }
        public double Radius { get; set; }

        public Circle(string name, double radius)
        {
            Name = name;
            Radius = radius;
        }
        public double Area()
        {
            double pi = Math.PI;
            return pi * Math.Pow(Radius, 2);
        }

        public void GetInfo()
        {
            Console.WriteLine(" I am a " + Name);
        }
    }
}
