using System;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = double.Parse(Console.ReadLine());
            var currencyType1 = Console.ReadLine().ToLower();
            var currencyType2 = Console.ReadLine().ToLower();


            int bgn = 1;
            var usd = 1.79549;
            var eur = 1.95583;
            var gbp = 2.53405;
            var bgnValue = 0.0;

            if (currencyType1 == "bgn")
            {
                bgnValue = value * bgn;
            }
            else if (currencyType1 == "usd")
            {
                bgnValue = value * usd;
            }
            else if (currencyType1 == "eur")
            {
                bgnValue = value * eur;
            }
            else if (currencyType1 == "gbp")
            {
                bgnValue = value * gbp;
            }

            if (currencyType2 == "bgn")
            {
                //Console.WriteLine(bgnValue);
                Console.WriteLine(Math.Round(bgnValue / bgn, 2) + " BGN");
            }
            else if (currencyType2 == "usd")
            {
                //Console.WriteLine(bgnValue);
                Console.WriteLine(Math.Round(bgnValue / usd, 2) + " USD");
            }
            else if (currencyType2 == "eur")
            {
                //Console.WriteLine(bgnValue);
                Console.WriteLine(Math.Round(bgnValue / eur, 2) + " EUR");
            }
            else if (currencyType2 == "gbp")
            {
                //Console.WriteLine(bgnValue);
                Console.WriteLine(Math.Round(bgnValue / gbp, 2) + " GB");
            }

        }
    }
}
