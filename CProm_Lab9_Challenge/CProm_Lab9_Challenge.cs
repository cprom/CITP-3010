/////////////////////////////////////////////////////////////////////////////////////
//
// Name: Chen Prom 
// Date: 11/05/2023
// Class: CITP-3010
// Semester: FALL 2023
// Instructor’s Name:NICOLAS GUTIERREZ
//
// Program Title: CProm_Lab9_Challenge
// Program Description: Console Program that will read take in a user input of a string
//                      and check to see if it is found in a text file.  Use Do While loop.
//
/////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CProm_Lab9_Challenge
{
    class CProm_Lab9_Challenge
    {
        static void Main(string[] args)
        {
            // And close it before we start reading from it below.



            Console.WriteLine("Enter String to search for: ");  // Get user input.
            string word = Console.ReadLine();


            StreamReader sr = new StreamReader("../../../Dictionary.txt");     // Creates our StreamReader object, and opens our data file.
                                                                               // File must be located in the project folder.


            // Read the text file line by line.
            

            do
            {
                string data = sr.ReadLine();
                // Check if the line contains the word entered by the user.
                if (data.Contains(word.ToLower()))
                {
                    // The word was found.
                    Console.WriteLine("The word \"" + word + "\" was found in the Dictionary file.");
                    return;
                }
            }
            while (!sr.EndOfStream);
            // The word was not found.
            Console.WriteLine("The word \"" + word + "\" was not found in the Dictionary file.");

            sr.Close();


            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
    }
}



