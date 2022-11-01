using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            int guess = 0;
            int number;

            while (playAgain)
            {
                number = random.Next(1, 101);

                while (guess != number)
                {
                    Console.WriteLine("Guess a number 1-100");
                    guess = Convert.ToInt32(Console.ReadLine());

                    if (guess > number)
                    {
                        Console.WriteLine("Guess is too high");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine("Guess is too low");
                    }
                    else if (guess == number)
                    {
                        Console.WriteLine("You have won!");
                        playAgain = false;
                    }
                }
            }
        }
    }
}
