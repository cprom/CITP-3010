/////////////////////////////////////////////////////////////////////////////////////
//
// Name: Chen Prom 
// Date: 10/29/2023
// Class: CITP-3010
// Semester: FALL 2023
// Instructor’s Name:NICOLAS GUTIERREZ
//
// Program Title:CProm_Lab8_Challenge
// Program Description: Simple guess the number game using for loop to limit the
//                      user to 5 guesses.
//
/////////////////////////////////////////////////////////////////////////////////////


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CProm_Lab8_Challenge
{
    class CProm_Lab8_Challenge
    {
        static void Main(string[] args)
        {
            int number;				// This variable will store the random number that the user is trying to guess.
            int guess;				// This variable will be used to store the guesses that the player makes.

            // As usual, we seed the random number generator with our value time(NULL).
            Random rng = new Random();
            number = rng.Next(1, 100);

            // Here we generate a random number, this time in the range 1-100.


            // Display a simple message explaining the rules
            Console.WriteLine("Welcome! I have chosen a random number between 1 and 100. Try to guess it!");

            // Our while loop is based on the boolean variable "correct"
            // Because boolean variables evaluate to either true or false by definition, we can base loops of off just their value, as below.
            // In this loop, while correct is false (which we initialized it to above), then NOT false (!false) = true, and so the loop runs.
            // Once we change correct to true, !correct will evaluate to false, and our loop will terminate.

            for (int i = 1; i <= 5; i++) //use for loop to control number of user input.

            {
                Console.WriteLine("What is your guess: ");
                guess = Convert.ToInt32(Console.ReadLine());

                // Here we will use a series of if...else if statements to determine if the user guessed correctly,
                // guessed too low, or guessed too high, and display a message to inform them of that.
                if (i == 5 && guess != number)
                {
                    Console.WriteLine("Sorry out of guesses, GAME OVER!");
                    break;
                }
                if (number > guess)
                {
                    Console.WriteLine("That guess is too low! Try again!");
                }
                else if (number < guess)
                {
                    Console.WriteLine("Too high! Give it another shot!");
                }
                else
                {
                    Console.WriteLine("That's right! You win! Congratulations!");

                    // when the user guess right the program will stop.
                    break;
                }
               


            }
            
            
            Console.Write("Press any key to continue.  .  .");
            Console.ReadKey();


        }
    }
}



