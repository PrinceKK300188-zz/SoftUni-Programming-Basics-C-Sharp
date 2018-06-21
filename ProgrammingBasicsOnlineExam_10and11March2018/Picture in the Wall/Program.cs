using System;

namespace Picture_in_the_Wall
{
    class Program
    {
        static void Main(string[] args)
        {
            int wallHeight = int.Parse(Console.ReadLine());
            int wallWidth = int.Parse(Console.ReadLine());
            int pictureHeight = int.Parse(Console.ReadLine());
            int pictureCount = int.Parse(Console.ReadLine());

            //Площ на дупката в стената
            int wallArea = wallHeight * wallWidth;

            //Площ на картините
            int pictureArea = pictureHeight * pictureHeight * pictureCount;

            if (wallArea >= pictureArea)
            {
                int diff = wallArea - pictureArea;
                Console.WriteLine($"The pictures fit in the hole. Hole area is {diff} bigger than pictures area.");
            }
            else
            {
                int diff = pictureArea - wallArea;
                Console.WriteLine($"The pictures don't fit in the hole. Picture area is {diff} bigger than hole area.");
                
            }
           
        }
    }
}
