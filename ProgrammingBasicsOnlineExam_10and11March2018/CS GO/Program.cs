using System;

namespace CS_GO
{
    class Program
    {
        static void Main(string[] args)
        {
            int item = int.Parse(Console.ReadLine());
            

            int spendMoney = 0;

            if (item > 7)
            {
                Console.WriteLine("Sorry, you can't carry so many things!");
            }
            else
            {
                int money = int.Parse(Console.ReadLine());
                for (int i = 0; i < item; i++)
                {
                    string name = Console.ReadLine();

                    switch (name.ToLower())
                    {
                        case "ak47":
                            spendMoney += 2700;
                            break;
                        case "awp":
                            spendMoney += 4750;
                            break;
                        case "sg553":
                            spendMoney += 3500;
                            break;
                        case "grenade":
                            spendMoney += 300;
                            break;
                        case "flash":
                            spendMoney += 250;
                            break;
                        case "glock":
                            spendMoney += 500;
                            break;
                        case "bazooka":
                            spendMoney += 5600;
                            break;
                    }

                }

                if (spendMoney > money)
                {
                    int bb = spendMoney - money;
                    Console.WriteLine($"Not enough money! You need {bb} more money.");
                }
                else
                {
                    Console.WriteLine($"You bought all {item} items! Get to work and defeat the bomb!");
                }
            }

            
        }
    }
}
