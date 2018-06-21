using System;

namespace External_Evaluation
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());

            double poorMarkNumber = 0;            double satisfactoryMarkNumber = 0;            double goodMarkkNumber = 0;            double veryGoodMarkkNumber = 0;            double excellentMarkNumber = 0;
            for (int i = 1; i <= students; i++)
            {
                double points = double.Parse(Console.ReadLine());

                if (0 < points && points < 22.5)
                {
                    poorMarkNumber++;
                }
                else if (22.5 <= points && points < 40.5)
                {
                    satisfactoryMarkNumber++;
                }
                else if (40.5 <= points && points < 58.5)
                {
                    goodMarkkNumber++;
                }
                else if (58.5 <= points && points < 76.5)
                {
                    veryGoodMarkkNumber++;
                }
                else if (76.5 <= points && points <= 100)
                {
                    excellentMarkNumber++;
                }
            }


            Console.WriteLine($"{(poorMarkNumber * 100 / students):F2}% poor marks");
            Console.WriteLine($"{(satisfactoryMarkNumber * 100 / students):F2}% satisfactory marks");
            Console.WriteLine($"{(goodMarkkNumber * 100 / students):F2}% good marks");
            Console.WriteLine($"{(veryGoodMarkkNumber * 100 / students):F2}% very good marks");
            Console.WriteLine($"{(excellentMarkNumber * 100 / students):F2}% excellent marks");
        }
    }
}
