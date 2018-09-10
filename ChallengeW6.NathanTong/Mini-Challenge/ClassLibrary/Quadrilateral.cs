using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Quadrilateral : Shape
    {
        public float Side1Length { get; set; }
        public float Side2Length { get; set; }
        public float Side3Length { get; set; }
        public float Side4Length { get; set; }

        public Quadrilateral(float side1, float side2, float side3, float side4, string Color) : base(Color)
        {
            this.Side1Length = side1;
            this.Side2Length = side2;
            this.Side3Length = side3;
            this.Side4Length = side4;
        }

        public float GetPerimeter()
        {
            float perimeter = Side1Length + Side2Length + Side3Length + Side4Length;
            return perimeter;
        }

    }
}
