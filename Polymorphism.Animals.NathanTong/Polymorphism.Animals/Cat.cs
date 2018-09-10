using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism.Animals
{
     class Cat : Mammal
    {
        public string Meow;

        public Cat(string Legs, string Eyes, string Mouth, int LifeSpan, string Poop, string Hunger, string Move, string BloodTemp, string Fur, string Tail, string Meow)

            : base(Legs, Eyes, Mouth, LifeSpan, Poop, Hunger, Move, BloodTemp, Fur, Tail)

        {
            this.Meow = Meow;
        }
    }
}
