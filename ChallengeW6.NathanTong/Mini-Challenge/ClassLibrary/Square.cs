using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Square : Quadrilateral
    {
        public Square(string Color, float side1) : base(side1, side1, side1, side1, Color)
        {

        }

        public float GetArea()
        {
            float Area = Side1Length * Side1Length;
            return Area;
        }

    }
}
