using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Rectangle : Quadrilateral
    {
        public Rectangle(string Color, float side1, float side2) : base(side1, side2, side1, side2, Color)
        {

        }

        public float GetArea()
        {
            float Area = Side1Length * Side2Length;
            return Area;
        }

    }
}
