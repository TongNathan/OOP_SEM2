using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism.Animals
{
    abstract class Mammal : AnimalFunctions
    {
        public string Fur;
        public string Tail;

        public Mammal(string Legs, string Eyes, string Mouth, int LifeSpan, string Poop, string Hunger, string Move, string BloodTemp, string Fur, string Tail) 
           
            : base(Legs, Eyes, Mouth, LifeSpan, Poop, Hunger, Move, BloodTemp)

        {
            this.Fur = Fur;
            this.Tail = Tail;
        }
    }
}
