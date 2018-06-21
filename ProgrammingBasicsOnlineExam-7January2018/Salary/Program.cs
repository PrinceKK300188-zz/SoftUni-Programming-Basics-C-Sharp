using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            double salary = double.Parse(Console.ReadLine());
            int years = int.Parse(Console.ReadLine());
            string member = Console.ReadLine();

            double currentSalary = salary;
            int yearsToMaxSalary = 0;
            for (int i = 1; i < int.MaxValue; i++)
            {
                //За всяка година заплатата се увеличава с 6 %
                currentSalary = currentSalary + (currentSalary * 6.0 / 100.0);

                //Ако е член на синдиката в години различни от 5-та и 10-та се удържа 1%
                if (member.ToLower() == "yes" && (i % 5 != 0 || i % 10 != 0))
                {
                    currentSalary = currentSalary - (currentSalary * 1.0 / 100.0);
                }

                //Ако годината е 5-та се добавят 100 лв към заплатата
                if (i % 5 == 0)
                {
                    currentSalary += 100;
                }

                //Ако годината е 10-та се добавят още 100 лв към заплатата
                if (i % 10 == 0)
                {
                    currentSalary += 100;
                }

                //Заплатата при прослужени години
                if (years == i && currentSalary < 5000)
                {
                    Console.WriteLine($"Current salary: {currentSalary:f2}");
                }
                //Ако заплтата надмине 5000 прекъсваме
                else if (years >= i && currentSalary >= 5000)
                {
                    currentSalary = 5000;
                    Console.WriteLine($"Current salary: {currentSalary:f2}");
                    Console.WriteLine($"{yearsToMaxSalary} more years to max salary.");
                    break;
                }

                if (currentSalary >= 5000)
                {
                    yearsToMaxSalary = i - 1 - years;
                    Console.WriteLine($"{yearsToMaxSalary} more years to max salary.");
                    break;
                }
            }

        } 
    }
}
