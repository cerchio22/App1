// See https://aka.ms/new-console-template for more information
using System;

namespace GameExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // instructies van de game
            Console.WriteLine("Welkom bij de raadsel game!");
            Console.WriteLine("Ik denk aan een nummer tussen 1 en 10. Kan jij raden wat het getal is?");

            // Genereren van de nummers 1 tot en met 10
            Random random = new Random();
            int correctAnswer = random.Next(1, 11);

            // Loop totdat de player het antwoord heeft geraden
            bool correct = false;
            while (!correct)
            {
                // ophalen van het antwoord van de player
                Console.WriteLine("Voer je antwoord hier uit:");
                string input = Console.ReadLine();

                // Converteer de gok van de speler naar een geheel getal
                if (int.TryParse(input, out int guess))
                {
                    // Check of het antwoord goed is
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

