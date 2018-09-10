using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism.Animals
{
     class Snake : Reptile
    {
        public string Hiss; 

        public Snake(string Legs, string Eyes, string Mouth, int LifeSpan, string Poop, string Hunger, string Move, string BloodTemp, string Scales, string Hiss)

            : base(Legs, Eyes, Mouth, LifeSpan, Poop, Hunger, Move, BloodTemp, Scales)

        {
            this.Hiss = Hiss;
        }
    }
}
