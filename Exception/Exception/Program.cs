using System;

namespace ExceptionTests
{
    public class Program
    {
        public static void Main()
        {   
            try
            {
                Console.WriteLine("Enter a Number! ");
                int x = Int32.Parse(Console.ReadLine());
                int sum = 0;
                int y;

                if (x > 15)
                {
                    throw new FifteenExpection();
                }

                if (x <= 0)
                {
                    throw new ZeroExpection();
                }

                while (x !=0)
                {
                    y = x % 10;
                    sum = sum + y;
                    x = x / 10;
                }

                Console.WriteLine("Exception " + sum + " Pass!");
                Console.ReadLine();
            }

            catch (ZeroExpection zero)
            {
                Console.WriteLine(zero.Message);
                Console.ReadLine();
            }
            catch (FifteenExpection fifteen)
            {
                Console.WriteLine(fifteen.Message);
                Console.ReadLine();
            }

            DateTime time = DateTime.Now;
            Console.WriteLine(time.ToString("h:mm:ss tt"));
            Console.ReadLine();

        }
    }

    public class ZeroExpection : Exception
    {
        public ZeroExpection() :base("Exception must be above Zero")
        {

        }

    }

    public class FifteenExpection : Exception
    {
        public FifteenExpection() : base("Exception is over 15")
        {

        }
    }

}
