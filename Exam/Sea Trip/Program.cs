using System;

namespace Sea_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyForFood = double.Parse(Console.ReadLine());
            double moneyForSuv = double.Parse(Console.ReadLine());
            double moneyForHotel = double.Parse(Console.ReadLine());

            double moneyForGasolyne = (420.0 / 100 * 7.0) * 1.85;
            double moneyForFoodAndSuv = 3.0 * moneyForFood + 3.0 * moneyForSuv;
            double moneyHotelFor3days = moneyForHotel * 0.9 + moneyForHotel * 0.85 + moneyForHotel * 0.8;

            double totalSpendedSum = moneyForGasolyne + moneyForFoodAndSuv + moneyHotelFor3days;
            Console.WriteLine($"Money needed: {totalSpendedSum:f2}");
        }
    }
}
