using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Weapons
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepLooping = true;
            while (keepLooping == true)

            {
                Console.WriteLine("Please Select an Attack Type!!!");
                Console.WriteLine("1. Melee Attack!");
                Console.WriteLine("2. Ranged Attack!");
                Console.WriteLine("");
                int Option = int.Parse(Console.ReadLine());

                switch (Option)
                {
                    case 1:
                        {
                            Console.WriteLine("You Selected a Melee Attack!");
                            Console.ReadLine();
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("You Selected a Ranged Attack!");
                            Console.ReadLine();
                            break;

                        }

                    case 3:
                        {
                            Console.WriteLine("Exiting loop...");
                            Console.ReadLine();
                            keepLooping = false;
                            break;
                        }
                }
            }
        }
    }
}
