/* Name: Vance Brender-A-Brandis
   Date: 1/17/23
   Brief Desc.: Number guessing game 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW2___CSCI352__Remake_
{
    class NumGuess 
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("This is a simple number guessing game.");
            Console.WriteLine("I am going to think of a number between a min number and a max number. You will have to provide those.");

            int min;
            int max;

            Console.WriteLine("Enter a minimum number: ");
            string userInput = Console.ReadLine();
            min = Int32.Parse(userInput);

            Console.WriteLine("Enter a maximum number: ");
            userInput = Console.ReadLine();
            max = Int32.Parse(userInput);

            Console.WriteLine("Thinking of a number...");

            Random rnd = new Random();
            int num = rnd.Next(min, max);

            Console.WriteLine("Guess the number! (" + min + ", " + max + ")");
            userInput = Console.ReadLine();
            
            int userInputNum = Int32.Parse(userInput);

            int tries = 0;

            while (userInputNum != num)
            {
                if (userInputNum < num)
                {
                    Console.WriteLine("Your guess of " + userInputNum + " is too low. Try again!");
                    tries++;
                }
                else
                {
                    Console.WriteLine("Your guess of " + userInputNum + " is too high. Try again!");
                    tries++;
                }
                userInput = Console.ReadLine();
                userInputNum = Int32.Parse(userInput);
            }

            Console.WriteLine("Correct! It took you " + tries + " tries to guess the correct number.");
        }
    }
}
