using System;

namespace PowersofTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 1;
            for (int i = 0; i <= n; i ++)
            {
                for (int a = 0; a < i; a++)
                {
                    if (a == 0 && i==0)
                    {
                        sum *= 1;
                    }
                    else
                    {
                        sum *= 2;
                    }
                    
                }
                Console.WriteLine(sum);
                sum = 1;
            }
        }
    }
}
