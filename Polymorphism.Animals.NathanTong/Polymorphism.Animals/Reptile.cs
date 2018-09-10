using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism.Animals
{
    abstract class Reptile : AnimalFunctions
    {
        public string Scales;

        public Reptile(string Legs, string Eyes, string Mouth, int LifeSpan, string Poop, string Hunger, string Move, string BloodTemp, string Scales) 
            
            : base(Legs, Eyes, Mouth, LifeSpan, Poop, Hunger, Move, BloodTemp)

        {
            this.Scales = Scales;
        }

    }
}
