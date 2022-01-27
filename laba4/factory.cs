using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4
{
    public class factory: AbstractFactory
    {
        public override Base createShape(string shape) 
        {
            if (shape == "Circle")
                return new ccircle();

            if (shape == "Square")
                return new csquare();

            if (shape == "Triangle")
                return new ctriangle();

            if (shape == "Group")
                return new cgroup();
            return null;
        }
    }
}
