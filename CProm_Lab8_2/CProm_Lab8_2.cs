/////////////////////////////////////////////////////////////////////////////////////
// Name: Chen Prom 
// Date: 10/29/2023
// Class: CITP-3010
// Semester: FALL 2023
// Instructor’s Name:NICOLAS GUTIERREZ
//
// Program Title:CProm_Lab8_2
// Program Description: A program that replicates the magic 8-ball toy.
//                      Program will generate a random number between 1 and 5
//                      and will display text that is associated with the number
//                      add while loop to repeat program if user input 'y'.
//
/////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CProm_Lab8_1
{
    class CProm_Lab8_1
    {
        static void Main(string[] args)
        {
           

           bool continueProgram = true;  //variable use to determine if user wants to repeat the program.


           while(continueProgram)
            {
                Random rnd = new Random();      // Genereate random number
                int roll = rnd.Next(1, 6);      // store random number in roll varable
                                                // Change range to 6 because 5 will only generate int 1-4
                Console.WriteLine("I am the Magic 8-Ball!! Ask me a question and I will give you an answer.");
                Console.WriteLine("");
                Console.Write("Ask me a question:   ");
                string userQuestion = Console.ReadLine();


                Console.WriteLine("I will ask the univere and find you the answer...\n");  // Wait 500ms - 1000ms before printing '*' to console.  Simulating the 8 ball thinking.
                System.Threading.Thread.Sleep(500);
                Console.Write("*");
                System.Threading.Thread.Sleep(1000);
                Console.Write("*");
                System.Threading.Thread.Sleep(1000);
                Console.Write("*");
                System.Threading.Thread.Sleep(1000);
                Console.Write("*");

                Console.WriteLine("");

                Console.Write("Universe: ");
                if (roll == 1)                                                      // if and else if statement to check to see if roll is equal to random number.
                {
                    Console.WriteLine("It is Certain.");
                }
                else if (roll == 2)
                {
                    Console.WriteLine("Reply hazy, Try Again.");
                }
                else if (roll == 3)
                {
                    Console.WriteLine("Don't count on it.");
                }
                else if (roll == 4)
                {
                    Console.WriteLine("Signs points to yes.");
                }
                else
                {
                    Console.WriteLine("My Source say no.");
                }

                Console.WriteLine("");
                Console.WriteLine("Would you like to ask another questions? y/n");  //prompt user if they want to ask another question.
                char anotherQuestion = Convert.ToChar(Console.ReadLine());
                if(anotherQuestion == 'y')
                {
                    continueProgram = true;
                }
                else
                {
                    continueProgram = false;
                }

            }
        }
    }
}


