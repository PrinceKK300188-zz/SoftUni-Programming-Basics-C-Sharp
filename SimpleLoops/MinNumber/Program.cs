using System;

namespace MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int minNumber = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                int userinput = int.Parse(Console.ReadLine());
                if (userinput < minNumber)
                {
                    minNumber = userinput;
                }
            }
            Console.WriteLine(minNumber);
        }
    }
}
