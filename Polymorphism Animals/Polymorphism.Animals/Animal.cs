using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism.Animals
{
    abstract class Animal
    {
        public string Legs;
        public string Eyes;
        public string Mouth;


        public Animal(string Legs, string Eyes, string Mouth)
        {
            this.Legs = Legs;
            this.Eyes = Eyes;
            this.Mouth = Mouth;
        }
    }
}
