using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = double.Parse(Console.ReadLine());

            double workSum = sum * 100;
            int count2lv = 0;
            if (workSum >= 200)
            {

                for (int i = 0; i < int.MaxValue; i++)
                {
                    workSum = workSum - 200;
                    count2lv++;
                    if (workSum < 200)
                    {
                        break;
                    }
                }
            }
            int count1lv = 0;
            if (workSum >= 100)
            {
                for (int i = 0; i < int.MaxValue; i++)
                {
                    workSum = workSum - 100;
                    count1lv++;
                    if (workSum < 100)
                    {
                        break;
                    }
                }
            }

            int count50st = 0;
            if (workSum >= 50)
            {
                for (int i = 0; i < int.MaxValue; i++)
                {
                    workSum = workSum - 50;
                    count50st++;
                    if (workSum < 50)
                    {
                        break;
                    }
                }
            }

            int count20st = 0;
            if (workSum >= 20)
            {
                for (int i = 0; i < int.MaxValue; i++)
                {
                    workSum = workSum - 20;
                    count20st++;
                    if (workSum < 20)
                    {
                        break;
                    }
                }
            }

            int count10st = 0;
            if (workSum >= 10)
            {
                for (int i = 0; i < int.MaxValue; i++)
                {
                    workSum = workSum - 10;
                    count10st++;
                    if (workSum < 10)
                    {
                        break;
                    }
                }
            }

            int count5st = 0;
            if (workSum >= 5)
            {
                for (int i = 0; i < int.MaxValue; i++)
                {
                    workSum = workSum - 5;
                    count5st++;
                    if (workSum < 5)
                    {
                        break;
                    }
                }
            }

            int count2st = 0;
            if (workSum >= 2)
            {
                for (int i = 0; i < int.MaxValue; i++)
                {
                    workSum = workSum - 2;
                    count2st++;
                    if (workSum < 2)
                    {
                        break;
                    }
                }
            }

            int count1st = 0;
            if (workSum >= 1)
            {
                for (int i = 0; i < int.MaxValue; i++)
                {
                    workSum = workSum - 1;
                    count1st++;
                    if (workSum < 1)
                    {
                        break;
                    }
                }
            }

            int total = count2lv + count1lv + count50st + count20st + count10st + count5st + count2st + count1st;
            Console.WriteLine(total);
        }
    }
}


int countStrawberries = 0;
int countRaspberries = 0;
double workQuantity = quantity;




            if (workQuantity >= 15)
            {
                for (int i = 1; i <= Cherries; i++)
                {
                    workQuantity = workQuantity - 15;
                    countCherries++;
                    if (workQuantity< 15)
                    {
                        break;
                    }
                }
            }
            double workQuantityOptionOne = workQuantity;


            //Вариант 1
            if (workQuantityOptionOne >= 4.5)
            {

                for (int i = 1; i <= Raspberries; i++)
                {
                    workQuantityOptionOne = workQuantityOptionOne - 4.5;
                    countRaspberries++;
                    if (workQuantityOptionOne< 4.5)
                    {
                        break;
                    }
                }
            }
            if (workQuantityOptionOne >= 7.5)
            {
                for (int i = 1; i <= Strawberries; i++)
                {
                    workQuantityOptionOne = workQuantityOptionOne - 7.5;
                    countStrawberries++;
                    if (workQuantityOptionOne< 7.5)
                    {
                        break;
                    }
                }
            }

            double maxJuiceOptionOne = countCherries * 15 + countStrawberries * 7.5 + countRaspberries * 4.5;

//Вариант 2
double workQuantityOptionTwo = workQuantity;
int countStrawberriesTwo = 0;
int countRaspberriesTwo = 0;
            if (workQuantityOptionTwo >= 7.5)
            {
                for (int i = 1; i <= Strawberries; i++)
                {
                    workQuantityOptionTwo = workQuantityOptionTwo - 7.5;
                    countStrawberriesTwo++;
                    if (workQuantityOptionTwo< 7.5)
                    {
                        break;
                    }
                }
            }

            if (workQuantityOptionTwo >= 4.5)
            {

                for (int i = 1; i <= Raspberries; i++)
                {
                    workQuantityOptionTwo = workQuantityOptionTwo - 4.5;
                    countRaspberriesTwo++;
                    if (workQuantityOptionTwo< 4.5)
                    {
                        break;
                    }
                }
            }

            double maxJuiceOptionTwo = countCherries * 15 + countStrawberriesTwo * 7.5 + countRaspberriesTwo * 4.5;

            if (maxJuiceOptionTwo >= maxJuiceOptionOne)
            {
                Console.WriteLine($"{countRaspberriesTwo} Raspberries, {countStrawberriesTwo} Strawberries, {countCherries} Cherries. Juice: {maxJuiceOptionTwo} ml.");
            }
            else
            {
                Console.WriteLine($"{countRaspberries} Raspberries, {countStrawberries} Strawberries, {countCherries} Cherries. Juice: {maxJuiceOptionOne} ml.");
            }
