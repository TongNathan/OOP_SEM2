using System;
using System.Collections.Generic;
using System.Text;

namespace W1
{

        abstract class Vehicle
        {
                public string Name { get; set; }
                public int Seats { get; set; }
                public string FuelType { get; set; }
                public int FuelQuantity { get; set; }

                public Vehicle(string name) 
                {

                }

                public void Refuel(int quantity)
                {
                    FuelQuantity += quantity;
                }
        } 
    

    class Car : Vehicle
    {
        public  int NumberOfWheels { get; set; }
        public string Rego { get; set; }
        public Car() : base("Camry")
        {

        }

    }

    class Boat : Vehicle
    {
        public string Type { get; set; }
        public int MotorType { get; set; }
        public Boat(): base("Cool Ass Boat")
        {
            this.Type = "Sail";
        }

    }

}
