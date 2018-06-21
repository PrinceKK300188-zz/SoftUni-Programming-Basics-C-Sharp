using System;

namespace LeftandRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int leftSum = 0;
            int rightSum = 0;
            for (int i = 0; i < n; i++)
            {
                int leftinput = int.Parse(Console.ReadLine());

                leftSum += leftinput;
            }

            for (int i = 0; i < n; i++)
            {
                int rightinput = int.Parse(Console.ReadLine());

                rightSum += rightinput;
            }
            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes, sum = {0}", rightSum);
            }
            else
            {
                Console.WriteLine("No, diff = {0}", Math.Abs(leftSum - rightSum));
            }

        }
    }
}
