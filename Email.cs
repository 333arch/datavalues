using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Printed(string Email)
        {
            if (Email.IndexOf('8') != -1)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
        static void Main(String[] args)
        {
            Console.WriteLine("Please input an email address");
            string Email = Console.ReadLine();
            Printed(Email);
        }
    }
}
