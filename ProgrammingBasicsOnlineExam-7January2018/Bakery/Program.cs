

using System;

namespace Bakery
{
    class Program
    {
        static void Main(string[] args)
        {
            //Количесто стартово тесто в грамове
            int startdough = int.Parse(Console.ReadLine());
            //Грамаж на закуските
            int breadGr = int.Parse(Console.ReadLine());
            //Цена на закуската
            double breadPrice = double.Parse(Console.ReadLine());
            //Брой продадени закуски
            int breadSell = int.Parse(Console.ReadLine());
            //Брой продадени сладкиши
            int cakeSell = int.Parse(Console.ReadLine());

            //Цена за килограм тесто 4 лв
            //сладкишите съдържат 20 % по-малки тесто и се продават с 25 % по-скъпо.

            //Приходи от продадени хлебни изделия
            double breadMoneyForTheDay = breadSell * breadPrice;

            //Мужно количество тесто за направата на тестените изделия
            int doughForBreadTotal = breadGr * breadSell;

            //Проверка дали не се е налагало да се произведе ново тесто за хлебчетата
            int count = 1;
            if (startdough < doughForBreadTotal)
            {

                for (int i = 0; i < doughForBreadTotal / startdough; i++)
                {
                    count++;
                }

            }

            //Останало тесто
            int doughLeftAfterBread = startdough * count - doughForBreadTotal;

            //Количество ново тесто прозиведено за сладкишите
            int newDougtForCake = startdough * count - doughLeftAfterBread;

            //Тесто нужно за един сладкиш
            double dougtForOneCake = breadGr - (breadGr / 5.0);

            //Тесто нужно за всички сладкиши
            double dougtForAllCakes = dougtForOneCake * cakeSell;

            int count2 = 1;
            if (startdough < dougtForAllCakes)
            {
                for (int i = 0; i < dougtForAllCakes / startdough; i++)
                {
                    count2++;
                }
            }



            //Цена на един сладкиш
            double priceForOneCake = breadPrice + breadPrice / 4.0;

            //Приходи от продадени сладкиши
            double cakeMoneyForTheDay = cakeSell * priceForOneCake;

            //Общо приходи за деня
            double totalIncome = breadMoneyForTheDay + cakeMoneyForTheDay;


            //Общо произведено тесто за деня
            int totalDougtForTheDay = startdough * count + startdough * (count2 - 1) + newDougtForCake;

            //Сума изразходвана за производството на тестото
            double totalDougtSum = 4.0 * (totalDougtForTheDay / 1000.0);

            //Печалба
            double income = totalIncome - totalDougtSum;

            //Общо изразходвано тесто за деня
            double totalusedDougtForTheDay = breadSell * breadGr + cakeSell * dougtForOneCake;

            Console.WriteLine($"Pure income: {income:F2} lv."); ;
            Console.WriteLine("Dough used: {0} g.", Math.Round(totalusedDougtForTheDay, 0));


        }
    }
}
