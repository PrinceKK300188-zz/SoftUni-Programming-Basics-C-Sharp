using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aedano
{
    class Program
    {
        static void Main(string[] args)
        {
            var raspberries = int.Parse(Console.ReadLine());
            var strawberries = int.Parse(Console.ReadLine());
            var cherries = int.Parse(Console.ReadLine());
            var maxJuice = int.Parse(Console.ReadLine());
            double currentJuice = 0;
            double max = 0;
            for (double i = 0; i <= raspberries; i++)
            {
                for (double j = 0; j <= strawberries; j++)
                {
                    for (double k = 0; k <= cherries; k++)
                    {
                        currentJuice = (i * 4.5) + (j * 7.5) + (k * 15);
                        if (currentJuice <= maxJuice)
                        {
                            if (currentJuice > max)
                            {
                                max = currentJuice;
                            }

                        }

                    }
                }
            }
            for (double i = 0; i <= raspberries; i++)
            {
                for (double j = 0; j <= strawberries; j++)
                {
                    for (double k = 0; k <= cherries; k++)
                    {
                        currentJuice = (i * 4.5) + (j * 7.5) + (k * 15);
                        if (currentJuice == max)
                        {
                            Console.WriteLine("{0} Raspberries, {1} Strawberries, {2} Cherries. Juice: {3} ml.", i, j, k, currentJuice);
                            return;
                        }
                    }
                }
            }
        }
    }
}
