using System;

namespace Slot_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            char n = Char.Parse(Console.ReadLine());
            int n1 = int.Parse(Console.ReadLine());
            char m = Char.Parse(Console.ReadLine());
            int m1 = int.Parse(Console.ReadLine());
            char k = Char.Parse(Console.ReadLine());
            int k1 = int.Parse(Console.ReadLine());


            int nn = Convert.ToInt32(n) + n1;
            char nnn = Convert.ToChar(nn);
            int mm = Convert.ToInt32(m) + m1;
            char mmm = Convert.ToChar(mm);
            int kk = Convert.ToInt32(k) + k1;
            char kkk = Convert.ToChar(kk);

            if (nn == 64 && mm == 64 && kk == 64)
            {
                Console.Write(nnn); Console.Write(mmm); Console.WriteLine(kkk);
                Console.WriteLine("!!! YOU LOSE EVERYTHING !!!");
            }
            else if (nn == 55 && mm == 55 && kk == 55)
            {
                Console.Write(nnn); Console.Write(mmm); Console.WriteLine(kkk);
                Console.WriteLine("*** JACKPOT ***");
            }
            else
            {
                Console.Write(nnn); Console.Write(mmm); Console.WriteLine(kkk);
            }
            
        }
    }
}
