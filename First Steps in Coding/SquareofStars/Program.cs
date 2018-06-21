using System;

namespace SquareofStars
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('*', number));
            for (int i = 1; i <= number-2; i++)
            {
                
                Console.WriteLine('*' + new string(' ', number-2) + '*');
                
            }
            Console.WriteLine(new string('*', number));
            //Console.WriteLine("Hello World!");
        }
    }
}
