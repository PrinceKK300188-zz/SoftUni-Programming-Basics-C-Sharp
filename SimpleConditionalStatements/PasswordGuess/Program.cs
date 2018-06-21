using System;

namespace PasswordGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            var pass = Console.ReadLine();
           

            var password = "s3cr3t!P@ssw0rd";
            String cPassword = password.ToString();

            if (pass == cPassword)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
