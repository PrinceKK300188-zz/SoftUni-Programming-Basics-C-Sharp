using System;

namespace FriendlyTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дистанция в километри
            int distanceKm = int.Parse(Console.ReadLine());


            //Разход на бензин за 100 километра
            int gasolinePer100 = int.Parse(Console.ReadLine());
            
            //Цена на горивото за литър
            double fuelCost1litter = double.Parse(Console.ReadLine());

            //Сума на разположение
            int sumForSpend = int.Parse(Console.ReadLine());

            //Колко литра бензин ще са необходими
            double gasolinNeeded = (distanceKm / 100.0) * gasolinePer100;

            //Колко ще струва пътуването
            double tripCost = gasolinNeeded * fuelCost1litter;

            //Могат ли да платят или не
            if (sumForSpend >= tripCost)
            {
                //Колко пари остават
                double moneyLeft = sumForSpend - tripCost;
                
                Console.WriteLine($"You can take a trip. {moneyLeft:F2} money left.");
            }
            else
            {
                double moneyForEveryone = sumForSpend / 5.0;
                Console.WriteLine($"Sorry, you cannot take a trip. Each will receive {moneyForEveryone:F2} money.");
            }
           
        }
    }
}
