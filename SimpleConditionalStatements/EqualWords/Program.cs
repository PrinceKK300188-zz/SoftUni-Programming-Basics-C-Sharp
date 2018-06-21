using System;

namespace EqualWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstWord = Console.ReadLine();
            var secondWord = Console.ReadLine();

           
            String cfirstWord = firstWord.ToString();
            String csecondWord = secondWord.ToString();

            if (cfirstWord.ToLower() == csecondWord.ToLower())
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            
        }
    }
}
