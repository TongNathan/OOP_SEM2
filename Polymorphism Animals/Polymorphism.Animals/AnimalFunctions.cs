using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism.Animals
{
    abstract class AnimalFunctions : Animal
    {
        public abstract int LifeSpan();
        public abstract string Poop();
        public abstract string Hunger();
        public abstract string Move();
        public abstract string BloodTemp();

        public AnimalFunctions(string Legs, string Eyes, string Mouth, int LifeSpan, string Poop, string Hunger, string Move, string BloodTemp) 

            :base (Legs, Eyes, Mouth)

        {

        }
    }
}
