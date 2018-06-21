using System;

namespace Calorie_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string gender = Console.ReadLine();
            double weight = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string active = Console.ReadLine();

            double bhm = 0;
            if (gender == "m")
            {

                bhm = 66 + (13.7 * weight) + (5 * height * 100) - (6.8 * age);
            }
            else if (gender == "f")
            {
                bhm = 655 + (9.6 * weight) + (1.8 * height * 100) - (4.7 * age);
            }

            switch (active)
            {
                case "sedentary":
                    bhm = bhm * 1.2;
                    break;
                case "lightly active":
                    bhm = bhm * 1.375;
                    break;
                case "moderately active":
                    bhm = bhm * 1.55;
                    break;
                case "very active":
                    bhm = bhm * 1.725;
                    break;
            }
            

            Console.WriteLine($"To maintain your current weight you will need {Math.Ceiling(bhm)} calories per day.");
        }
    }
}
