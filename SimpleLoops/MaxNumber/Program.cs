using System;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int maxNumber = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int userinput = int.Parse(Console.ReadLine());
                if (userinput > maxNumber)
                {
                    maxNumber = userinput;
                }
            }
            Console.WriteLine(maxNumber);
        }
    }
}
