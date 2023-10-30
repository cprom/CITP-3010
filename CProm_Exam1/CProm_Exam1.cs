/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
// Name: Chen Prom 
// Date: 10/1/2023
// Class: CITP-3010
// Semester: FALL 2023
// Instructor’s Name:NICOLAS GUTIERREZ
//
// Program Title:CProm_Exam1
// Program Description: Program to take 5 integers from user input and 5 integer from text file and find the differences.
//
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CProm_Exam1
{
    class CProm_Exam1
    {
        static void Main(string[] args)
        {

            int number1, number2, number3, number4, number5;  // Declare 5 variables to hold numbers input by user.
            int UserSum;    // Declare variable to hold the sum of 5 user input numbers.
            int FileSum;    // Declare variable to hold the sum of 5 numbers from text file.
            int Difference; // Declare variable to hold the difference between UserSum and FileSum.

            // Get 5 user inputs.
            Console.Write("Enter your 1st number: ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter your 2nd number: ");
            number2 = int.Parse(Console.ReadLine());
            Console.Write("Enter your 3rd number: ");
            number3 = int.Parse(Console.ReadLine());
            Console.Write("Enter your 4th number: ");
            number4 = int.Parse(Console.ReadLine());
            Console.Write("Enter your 5th number: ");
            number5 = int.Parse(Console.ReadLine());

            UserSum = number1 + number2 + number3 + number4 + number5; // calculate the sum of 5 user input.

            string[] result = File.ReadAllLines("MyNumbers.txt");  // Read from text file found in <project name>/bin/Debug/net7.0 in to string array.

            int numFromTxt1 = int.Parse(result[0]); // Get value from index 0 and store in variable
            int numFromTxt2 = int.Parse(result[1]); // Get value from index 1 and store in variable
            int numFromTxt3 = int.Parse(result[2]); // Get value from index 2 and store in variable
            int numFromTxt4 = int.Parse(result[3]); // Get value from index 3 and store in variable
            int numFromTxt5 = int.Parse(result[4]); // Get value from index 4 and store in variable

            FileSum = (numFromTxt1 + numFromTxt2 + numFromTxt3 + numFromTxt4 + numFromTxt5) / 5;  // calculate the sum of 5 numbers from text file.

            Difference = UserSum - FileSum; // Calculate the differnce of UserSum and FileSum.

            StreamWriter sw = new StreamWriter("Difference.txt");   
            sw.WriteLine($"The difference between {UserSum} and {FileSum} is {Difference}."); // Write line to text file.
            sw.Close(); // close file.

            Console.WriteLine();
            Console.WriteLine($"The difference between {UserSum} and {FileSum} is {Difference}."); // Display text.

        }
    }
}


