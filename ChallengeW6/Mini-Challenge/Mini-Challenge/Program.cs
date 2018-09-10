using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;


namespace Mini_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {

            bool keepLooping = true;
            while (keepLooping == true)

            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Create a square");
                Console.WriteLine("2. Create a rectangle");
                Console.WriteLine("3. Exit Application.");
                Console.WriteLine("");
                int Option = int.Parse(Console.ReadLine());

                try
                {
                    switch (Option)
                    {
                        case 1:
                            {
                                Console.WriteLine("Enter colour");
                                string color = Console.ReadLine();
                                Console.WriteLine("Enter Side 1");
                                float Side1Length = float.Parse(Console.ReadLine());
                                Square square = new Square(color, Side1Length);
                                Console.WriteLine(square.GetArea());

                                if (Side1Length <= 0)
                                {
                                    throw new zeroException();
                                }

                                Console.ReadLine();
                                break;
                            }

                        case 2:
                            {
                                Console.WriteLine("Enter colour");
                                string color = Console.ReadLine();
                                Console.WriteLine("Enter Side 1");
                                float Side1Length = float.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Side 2");
                                float Side2Length = float.Parse(Console.ReadLine());
                                Rectangle rectangle = new Rectangle(color, Side1Length, Side2Length);
                                Console.WriteLine(rectangle.GetArea());

                                if (Side1Length <= 0)
                                {
                                    throw new zeroException();
                                }
                                if (Side2Length <= 0)
                                {
                                    throw new zeroException();
                                }

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
                
                catch (zeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadLine();
            }
        }

        public class zeroException : Exception
        {
            public zeroException() : base("Must be greater then 0")
            {

            }
        }
    }
}
