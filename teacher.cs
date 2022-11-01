using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Printed(string First, string Middle, string Last)
        {
            string First2 = First.Substring(0, 1);
            string Middle2 = Middle.Substring(0, 1);
            string Last2 = Last.Substring(0, 1);
            Console.WriteLine(First2.ToUpper() + Middle2.ToUpper() + Last2.ToUpper()); 
        }
        static void Main(String[] args)
        {
            Console.WriteLine("Please input your first name");
            string First = Console.ReadLine();
            Console.WriteLine("Please input your middle name");
            string Middle = Console.ReadLine();
            Console.WriteLine("Please input your last name");
            string Last = Console.ReadLine();
            Printed(First, Middle, Last);
        }
    }
}
