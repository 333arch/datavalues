using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Conversion()
        {
            Console.WriteLine("Please enter the Letter you wish to know the ASCII and EBCDIC");
            char Letter = char.Parse(Console.ReadLine());
            Console.WriteLine($"The letter {Letter} in ASCII is {(int)Letter} and in EBCDIC it is {(int)Letter + 32}");
        }
        static void Main(String[] args)
        {
            Conversion();
        }
    }
}
