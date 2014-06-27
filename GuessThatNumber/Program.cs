using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessThatNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Want to play a game?");
            GuessThatNumber();
            Console.ReadKey();
        }
        static void GuessThatNumber()
        {
            Console.WriteLine("What number am I thinking of?");
            Random compGuess = new Random();
            int randomNum = compGuess.Next(1, 101);
            int count = 0;
            int newInput = 0;
            Console.WriteLine("Take a guess.");
            while (newInput != randomNum)
            {
                string yourGuess = Console.ReadLine();
                int input = int.Parse(yourGuess);
                if (input < randomNum)
                {
                    Console.WriteLine("Go higher.");
                    count++;
                }
                else if (input > randomNum)
                {
                    Console.WriteLine("Go lower.");
                    count++;
                }
                else if (input == randomNum)
                {
                    Console.WriteLine("You got it right! You took " + (count + 1) + " guesses. Want to play again?");
                }
            }
        }
    }
}