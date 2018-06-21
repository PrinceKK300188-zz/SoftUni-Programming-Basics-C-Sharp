using System;

namespace EnterEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < int.MaxValue; i++)
            {
                Console.Write("Enter even number: ");
                var UserInput = Console.ReadLine();

                try  {
                    //Проверка дали четно цялото число
                    if (int.Parse(UserInput) % 2 == 0)
                    {
                        Console.WriteLine($"Even number entered: {UserInput}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The number is not even.");
                        continue;
                    }
                    
                }
                catch
                {
                    Console.WriteLine("Invalid number!");
                };
            }


        }
    }
}
