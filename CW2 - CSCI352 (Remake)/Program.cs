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
            Console.WriteLine("I am going to think of a number between 0 and 100. Then, you will have to try and guess the number I thought up!");
            Console.WriteLine("Thinking of a number...");

            Random rnd = new Random();
            int num = rnd.Next(0, 100);

            Console.WriteLine("Guess the number! (0-100)");

            string userInput = Console.ReadLine();
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
