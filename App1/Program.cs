// See https://aka.ms/new-console-template for more information
using System;

namespace GameExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome message and instructions
            Console.WriteLine("Welkom bij de raadsel game!");
            Console.WriteLine("Ik denk aan een nummer tussen 1 en 10. Kan jij raden wat het getal is?");

            // Generate a random number between 1 and 10
            Random random = new Random();
            int correctAnswer = random.Next(1, 11);

            // Loop until the player guesses the correct answer
            bool correct = false;
            while (!correct)
            {
                // Get player's guess
                Console.WriteLine("Voer je antwoord hier uit:");
                string input = Console.ReadLine();

                // Convert player's guess to an integer
                if (int.TryParse(input, out int guess))
                {
                    // Check if the guess is correct
                    if (guess == correctAnswer)
                    {
                        Console.WriteLine("Gefeliciteerd, je hebt het antwoord geraden.");
                        correct = true;
                    }
                    else
                    {
                        Console.WriteLine("Mehhh, Fout. Probeer opnieuw.");
                    }
                }
                else
                {
                    Console.WriteLine("Verkeerde nummer. Probeer opnieuw.");
                }
            }
        }
    }
}

