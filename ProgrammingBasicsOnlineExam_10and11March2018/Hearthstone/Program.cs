using System;

namespace Hearthstone
{
    class Program
    {
        static void Main(string[] args)
        {
            int uBreak = int.Parse(Console.ReadLine());
            double cardPrice = double.Parse(Console.ReadLine());
            double adventurePrice = double.Parse(Console.ReadLine());
            double coffeePrice = double.Parse(Console.ReadLine());

            //Време след паузата
            int time = uBreak - 5;

            //Време за разпускане след покупките
            time = time - 10;

            //Похарчени пари
            double spendMoney = cardPrice * 3.0 + adventurePrice * 2.0 + coffeePrice;

            Console.WriteLine($"{spendMoney:F2}");
            Console.WriteLine($"{time}");
            
        }
    }
}
