using System;
using System.Linq;

//Number guessing Game

Console.WriteLine("Im thinking of a number from 1 to 100 Guess it!");


Random Rng = new Random();
int RandomNumber = Rng.Next(1,101);
int GuessCounter = 1;
int MaxGuesses = 10;

while (true)
    {
        

        string UserInput = Console.ReadLine();
    if (!int.TryParse(UserInput, out int guess))
    {
        Console.WriteLine("Please enter a number");
        continue;
    }

        if (guess > 100 || guess < 1)
        {
            Console.WriteLine("You are out of range(1-100) guess again");
            continue;
        }

        if (GuessCounter == MaxGuesses)
        {
            Console.WriteLine("You have reached the maximum amount of guesses");
            Console.WriteLine("The number was " + RandomNumber);
            break;
         }



        if (guess == RandomNumber)
        {
            Console.WriteLine("You guessed Right!");
            Console.WriteLine("Guesses: " + GuessCounter);
            break;
        }

        else if (guess > RandomNumber)
        {
            GuessCounter += 1;
            Console.WriteLine("Guesses: " + GuessCounter);
            Console.WriteLine("Nope the number is Lower");
            Console.WriteLine("Enter your Guess");
            
        }

        else if (guess < RandomNumber)
        {
            GuessCounter += 1;
            Console.WriteLine("Guesses: " + GuessCounter);
            Console.WriteLine("Nope the number is Higher");
            Console.WriteLine("Enter your Guess");
            

        }
    }
