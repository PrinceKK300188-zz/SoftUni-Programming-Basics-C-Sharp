using System;

namespace MultiplyTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int firstDigit = number % 10;
            int r = number / 10;
            int secondDigit = r % 10;
            int thirdDigit = r / 10;

            for (int a = 1; a <= firstDigit; a++)
            {
                for (int b = 1; b <= secondDigit; b++)
                {
                    for (int c = 1; c <= thirdDigit; c++)
                    {
                        Console.WriteLine($"{a} * {b} * {c} = {a*b*c};");
                    }
                }
            }

        }
    }
}
