using System;

namespace LatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {

            for (var i = 0; i < 26; i++)
            {
                
                Console.WriteLine(string.Format("{0}", Convert.ToChar('a' + i)));
            }
            
        }
    }
}