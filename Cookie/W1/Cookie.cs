using System;
using System.Collections.Generic;
using System.Text;

namespace W1
{
    class Cookie
    {
        public string Color { get; set; }
        public string Shape { get; set; }
        public string Topping { get; set; }
        public DateTime CreatedDate { get; private set; }

        public Cookie(string color, string shape, string topping, DateTime createdDate)
        {
            this.Color = color;
            this.Shape = shape;
            this.Topping = topping;
            this.CreatedDate = createdDate;
        }
        
        public void BakeCookie(int secondsInOven)
        {
            Console.WriteLine("Baking Cookie for:" + secondsInOven + "seconds.");
        }

        public bool OutOfDate(int daysForExpiry)
        {
            if(CreatedDate.AddDays(daysForExpiry) >= DateTime.Now)
            {
                return true;
            }



            return false;
        }





    }
}
