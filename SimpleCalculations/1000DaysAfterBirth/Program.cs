using System;

namespace _1000DaysAfterBirth
{
    class Program
    {
        static void Main(string[] args)
        {
            
        DateTime result = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
                
        //DateTime searchDate = result.AddDays(999);
                
        Console.WriteLine(result.AddDays(999).ToString("dd-MM-yyyy"));


        }
    }
}
