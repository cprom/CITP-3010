/////////////////////////////////////////////////////////////////////////////////////
//
// Name: Chen Prom 
// Date: 9/14/2023
// Class: CITP-3010
// Semester: FALL 2023
// Instructor’s Name:NICOLAS GUTIERREZ
//
// Program Title:CProm_Lab2
// Program Description: A program that prints out the average of 3 grades and creates a .txt file.
//
/////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class CProm_Lab2
    {
        static void Main(string[] args)
        {
            //Declare 5 variables
            string firstName; //variable to hold string
            int assignmentScore1, assignmentScore2, assignmentScore3; // varialbe to hold int
            double averageScore; //variable to hold double

            //assign valuet to varables
            firstName = "Bella";    
            assignmentScore1 = 85;  
            assignmentScore2 = 95;
            assignmentScore3 = 92;

            averageScore = (assignmentScore1 + assignmentScore2 + assignmentScore3) / 3.0; // calculate average of 3 score

            string averageModified = string.Format("{0:0.0000}", averageScore); // create a string that display 4 decimal places

            Console.WriteLine($"The average score of {firstName} is {averageModified}");  // Display message with first name and score average to console.

            //Pass the filepath and filename to the StreamWriter Constructor
            //Text file will be created in in the working directory <project name>/bin/Debug/net6.0
            StreamWriter sw = new StreamWriter("lab2_Results.txt");
            //Write a line of text
            sw.WriteLine($"The average score of {firstName} is {averageModified}");
            //Close the file
            sw.Close();
        }
    }
}
