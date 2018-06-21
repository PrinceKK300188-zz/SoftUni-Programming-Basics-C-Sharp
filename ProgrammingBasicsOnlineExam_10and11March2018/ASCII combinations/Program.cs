using System;
using System.Collections.Generic;

namespace ASCII_combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            Dictionary<int, char> num = new Dictionary<int, char>();
            Dictionary<int, char> smallLetter = new Dictionary<int, char>();
            Dictionary<int, char> capitalLetter = new Dictionary<int, char>();
            Dictionary<int, char> other = new Dictionary<int, char>();

            int countNum = 0;
            int sumNum = 0;
            int countCapLet = 0;
            int sumCapLet = 0;
            int countSmallLet = 0;
            int sumSmallLet = 0;
            int countOther = 0;
            int sumOther = 0;

            for (int i = 0; i < n; i++)
            {
                char symbol = Char.Parse(Console.ReadLine());

                
                int nn = Convert.ToInt32(symbol);

                if (nn >= 48 && nn <= 57)
                {
                    num[countNum] = symbol;
                    countNum++;
                    sumNum += nn;
                }
                else if (nn >= 65 && nn <= 90)
                {
                    capitalLetter[countCapLet] = symbol;
                    countCapLet++;
                    sumCapLet += nn;
                }
                else if (nn >= 97 && nn <= 122)
                {
                    smallLetter[countSmallLet] = symbol;
                    countSmallLet++;
                    sumSmallLet += nn;
                }
                else
                {
                    other[countOther] = symbol;
                    countOther++;
                    sumOther += nn;
                }

                //char nnn = Convert.ToChar(nn);
                
            }

            if (sumNum >= sumCapLet && sumNum >= sumSmallLet && sumNum >= sumOther)
            {
                Console.WriteLine($"Biggest ASCII sum is:{sumNum}");
                Console.Write("Combination of characters is:");
                for (int i = 0; i < num.Count; i++)
                {
                    Console.Write(num[i]);
                }
                Console.WriteLine();
            }
            else if (sumCapLet >= sumNum && sumCapLet >= sumSmallLet && sumCapLet >= sumOther)
            {
                Console.WriteLine($"Biggest ASCII sum is:{sumCapLet}");
                Console.Write("Combination of characters is:");
                for (int i = 0; i < capitalLetter.Count; i++)
                {
                    Console.Write(capitalLetter[i]);
                }
                Console.WriteLine();
            }
            else if (sumSmallLet >= sumCapLet && sumSmallLet >= sumNum && sumSmallLet >= sumOther)
            {
                Console.WriteLine($"Biggest ASCII sum is:{sumSmallLet}");
                Console.Write("Combination of characters is:");
                for (int i = 0; i < smallLetter.Count; i++)
                {
                    Console.Write(smallLetter[i]);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"Biggest ASCII sum is:{sumOther}");
                Console.Write("Combination of characters is:");
                for (int i = 0; i < other.Count; i++)
                {
                    Console.Write(other[i]);
                }
                Console.WriteLine();
            }

            
        }
    }
}
