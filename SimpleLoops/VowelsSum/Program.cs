using System;

namespace VowelsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();

            int value = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (NewMethod(s, i) == 'a')
                {
                    value += 1;
                    Console.WriteLine("a");
                }
                else if (NewMethod(s, i) == 'e')
                {
                    value += 2;
                    Console.WriteLine("e");
                }
                else if (NewMethod(s, i) == 'i')
                {
                    value += 3;
                    Console.WriteLine("i");
                }
                else if (NewMethod(s, i) == 'o')
                {
                    value += 4;
                    Console.WriteLine("o");
                }
                else if (NewMethod(s, i) == 'u')
                {
                    value +=5;
                    Console.WriteLine("u");
                }
                //Console.WriteLine("aaaaaaaaaaaaaa " + i + " aaaaaaaaaaaaaaa");
            }

            Console.WriteLine(value);
        }

        private static char NewMethod(string s, int i)
        {
            return s[i];
        }
    }
}
