﻿using System;

namespace USDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            var usd = double.Parse(Console.ReadLine());

            Console.WriteLine(Math.Round(usd* 1.79549, 2) + " BGN");
        }
    }
}
