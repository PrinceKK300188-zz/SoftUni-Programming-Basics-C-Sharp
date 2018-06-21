using System;

namespace PC_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double procPrice = double.Parse(Console.ReadLine());
            double videoPrice = double.Parse(Console.ReadLine());
            double ramPrice = double.Parse(Console.ReadLine());
            int numberRam = int.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            double procPriceLv = procPrice * 1.57;
            
            double videoPriceLv = videoPrice * 1.57;
            
            double ramPriceLv = ramPrice * 1.57;
            
            double ramTotal = ramPriceLv * numberRam;
            
            double procPriceLvD = procPriceLv - procPriceLv * discount;
            
            double videoPriceLvD = videoPriceLv - videoPriceLv * discount;
            
            double sum = procPriceLvD + videoPriceLvD + ramTotal;



            Console.WriteLine($"Money needed - {sum:F2} leva.");
        }
    }
}
