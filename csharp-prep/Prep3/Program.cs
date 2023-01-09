using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int ramdom_number = randomGenerator.Next(1, 101);
        int guess_count = 0;
        Console.WriteLine("Welcome to the guees game!");
        Console.WriteLine("Try to guees the magic number between 1 and 100 :) ");

        while (true)
        {
            Console.WriteLine("What is the magic number? ");
            string guess = Console.ReadLine();
            int valid = int.Parse(guess);
            if (valid > ramdom_number)
            {
                Console.WriteLine("Too High");
                guess_count = guess_count + 1;
            }
            else if (valid < ramdom_number)
            {
                Console.WriteLine("Too Low");
                guess_count = guess_count + 1;
            }
            else
            {
                guess_count = guess_count + 1;
                break;
            }
        }
        Console.WriteLine($"You guessed it! It took you {guess_count} guesses");
    }
}