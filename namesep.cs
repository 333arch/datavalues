using System;

namespace ConsoleApp1
{
    class Program
    {
        static void NameSep(string FullName)
        {
            var Names = FullName.Split(" ");
            Console.WriteLine(Names[0]);
            Console.WriteLine(Names[1]);
        }
        static void Main(String[] args)
        {
            Console.WriteLine("Please input an your full name");
            string FullName = Console.ReadLine();
            NameSep(FullName);
        }
    }
}
