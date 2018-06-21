using System;

namespace CheckPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string output = "";
            if (n < 2)
            {
                Console.WriteLine("Not Prime"); 
            }
            else if (n == 2 || n == 3)
            {
                output = "Prime";
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i != 0)
                    {
                        output = "Prime";
                       
                    }
                    else
                    {
                        output = "Not Prime";
                        break;
                    }
                }
            }

                Console.WriteLine(output);

        }
    }
}
