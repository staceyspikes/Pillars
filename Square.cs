using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillars
{
    class Square : Shape
    {
        public double Length { get; set; }
        public Square(string name, double length) : base(name)
        {
            Length = length;
        }
        public override double Area()
        {
            return Length * Length;
        }
    }
}
