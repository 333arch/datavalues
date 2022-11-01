using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Printed(string City1, string City2)
        {
            string ShortCity1 = City1.Substring(0, 4);
            string ShortCity2 = City2.Substring(0, 4);
            Console.WriteLine(ShortCity1.ToUpper() + '-' + ShortCity2.ToUpper()); 
        }
        static void Main(String[] args)
        {
            Console.WriteLine("Please input your first city");
            string City1 = Console.ReadLine();
            Console.WriteLine("Please input your second city");
            string City2 = Console.ReadLine();
            Printed(City1, City2);
        }
    }
}
