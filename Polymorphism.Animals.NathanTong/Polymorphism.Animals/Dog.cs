using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism.Animals
{
     class Dog : Mammal
    {
        public string Woof;

        public Dog(string Legs, string Eyes, string Mouth, int LifeSpan, string Poop, string Hunger, string Move, string BloodTemp, string Fur, string Tail, string Woof)

             : base(Legs, Eyes, Mouth, LifeSpan, Poop, Hunger, Move, BloodTemp, Fur, Tail)

        {
        }

        public override string Move()
        {
            return "Run";
        }

        public override string Poop()
        {
            return "Mud Monkey";
        }



    }
}
