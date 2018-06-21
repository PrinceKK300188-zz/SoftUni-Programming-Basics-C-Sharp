using System;

namespace NewYearsEveParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int guests = int.Parse(Console.ReadLine());
            int budjet = int.Parse(Console.ReadLine());

            double sumForTheParty = guests * 20.0;
            if (sumForTheParty <= budjet)
            {
                double rest = budjet - sumForTheParty;
                double fireworks = rest * 40.0 / 100.0;
                fireworks = Math.Round(fireworks);
                double after = rest * 60.0 / 100.0;
                after = Math.Round(after);
                Console.WriteLine($"Yes! {fireworks} lv are for fireworks and {after} lv are for donation.");
            }
            else if (sumForTheParty > budjet)
            {
                double needed = sumForTheParty - budjet;
                needed = Math.Round(needed);
                Console.WriteLine($"They won't have enough money to pay the covert. They will need {needed} lv more.");
            }
            
        }
    }
}
