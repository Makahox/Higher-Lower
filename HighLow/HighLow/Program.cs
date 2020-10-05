using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLow
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Welcome Message
            Console.WriteLine("Welcome to the Higher Lower game.");
            


            // Choose a random number
            Random rng = new Random();
            int number = rng.Next(1, 11);
            int attempt = 1;

            while (true)
            {

                // Enter user guess
                Console.Write("Enter guess : ");
                int guess = Convert.ToInt32(Console.ReadLine());

                // Compare guess to number
                if (guess < number)
                {
                    Console.WriteLine("Too low, go higher.");
                    attempt = attempt + 1;
                }
                else if (guess > number)
                {
                    Console.WriteLine("Too high, go lower.");
                    attempt = attempt + 1;
                }
                else
                {
                    Console.WriteLine("Correct, well done.");
                    Console.WriteLine(attempt.ToString() + " guesses");
                    
                  
                    break;
                }
            }
            // Wait for a key press
            Console.ReadKey();

        }
    }
}
