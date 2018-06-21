using System;

namespace Illidan
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int force = int.Parse(Console.ReadLine());
            int gameforce = int.Parse(Console.ReadLine());

            int totalForce = number * force;
            if (gameforce > totalForce)
            {
                Console.WriteLine($"You are not prepared! You need {gameforce - totalForce} more points.");
            }
            else
            {
                Console.WriteLine($"Illidan has been slain! You defeated him with {totalForce - gameforce} points.");
          
            }
            
        }
    }
}
