using System;

namespace TradeComissions
{
    class Program
    {
        static void Main(string[] args)
        {
            var city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            double commision = 0.00;
            if (city == "Sofia")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commision = sales * 5 / 100;
                    Console.WriteLine("{0:f2}", commision);
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commision = sales * 7 / 100;
                    Console.WriteLine("{0:f2}", commision);
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commision = sales * 8 / 100;
                    Console.WriteLine("{0:f2}", commision);
                }
                else if (sales > 10000)
                {
                    commision = sales * 12 / 100;
                    Console.WriteLine("{0:f2}", commision);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (city == "Plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commision = sales * 5.5 / 100;
                    Console.WriteLine("{0:f2}", commision);
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commision = sales * 8 / 100;
                    Console.WriteLine("{0:f2}", commision);
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commision = sales * 12 / 100;
                    Console.WriteLine("{0:f2}", commision);
                }
                else if (sales > 10000)
                {
                    commision = sales * 14.5 / 100;
                    Console.WriteLine("{0:f2}", commision);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (city == "Varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commision = sales * 4.5 / 100;
                    Console.WriteLine("{0:f2}", commision);
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commision = sales * 7.5 / 100;
                    Console.WriteLine("{0:f2}", commision);
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commision = sales * 10 / 100;
                    Console.WriteLine("{0:f2}", commision);
                }
                else if (sales > 10000)
                {
                    commision = sales * 13 / 100;
                    Console.WriteLine("{0:f2}", commision);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }          
        }
    }
}
