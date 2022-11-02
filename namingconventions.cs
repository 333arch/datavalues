using System;

namespace ConsoleApp1
{
    class Program
    {
        static void NameSep(string[] Words, string Convention)
        {
            if (Convention == "kebab-case")
            {
                Console.WriteLine(Words[0] + '-' + Words[1]);
            }
            else if (Convention == "snake_case")
            {
                Console.WriteLine(Words[0] + '_' + Words[1]);
            }
            else if (Convention == "camalCase")
            {
                Console.WriteLine(Words[0] + Words[1].ToUpper().Remove(1) + Words[1].Remove(0,1));
            }
            else if (Convention == "PascalCase")
            {
                Console.WriteLine(Words[0].ToUpper().Remove(1) + Words[0].Remove(0, 1) + Words[1].ToUpper().Remove(1) + Words[1].Remove(0, 1));
            }
            else
            {
                Console.WriteLine("Invalid convention");
            }
        }
        static void Main(String[] args)
        {
            Console.WriteLine("Please input the Words");
            string[] Words = Console.ReadLine().Split(" ");
            Console.WriteLine(Words);
            Console.WriteLine("Please input the naming convention you want to use");
            string Convention = Console.ReadLine();
            NameSep(Words, Convention);
        }
    }
}
