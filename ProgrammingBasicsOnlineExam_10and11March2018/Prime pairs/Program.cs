using System;

namespace Prime_pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fStart = int.Parse(Console.ReadLine());
            int sStart = int.Parse(Console.ReadLine());
            int fdi = int.Parse(Console.ReadLine());
            int sdi = int.Parse(Console.ReadLine());

            for (int i = fStart; i <= (fStart+fdi); i++)
            {
                for (int k = sStart; k <= (sStart+sdi); k++)
                {

                    if (IsPrime(i) && IsPrime(k))
                    {
                        Console.Write($"{i}");
                        Console.WriteLine($"{k}");

                    }


                }
            }

        }

        public static bool IsPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}

