using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillars
{
    abstract class  Shape
    {
        public string Name { get; set; }

        abstract public double Area();
        public Shape(string name)
        {
            Name = name;
        }
        public void GetInfo()
        {
            Console.WriteLine("I am a {0}", Name);
        }
       

        
    }
}
