using System;

namespace ConsoleApp1
{
    class Program
    {
        static bool Tweetprob(string Message)
        {
            if (Message.Length <= 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(String[] args)
        {
            Console.WriteLine("Write your message");
            string Message = Console.ReadLine();
            Console.WriteLine(Tweetprob(Message));
        }
    }
}
