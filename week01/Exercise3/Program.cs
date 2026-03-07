using System;

class Program
{
    static void Main(string[] args)
    {
        // Generate a random number between 1 and 100
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        int attempts = 0;
        
        // For testing (steps 1 and 2)
        //Console.WriteLine("What is the magic number? ");
        //int magicNumber = Convert.ToInt32(Console.ReadLine());

        // what is your guess?
        Console.WriteLine("What is your guess? ");
        int guess = Convert.ToInt32(Console.ReadLine());

        //loop until the guess is correct
        while (guess != number)
        {
            attempts++;
             if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }

            Console.WriteLine("What is your guess? ");
            guess = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("You guessed it!");
        Console.WriteLine($"It took you {attempts} attempts.");
    }
}