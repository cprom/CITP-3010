/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
// Name: Chen Prom 
// Date: 10/1/2023
// Class: CITP-3010
// Semester: FALL 2023
// Instructor’s Name:NICOLAS GUTIERREZ
//
// Program Title:CProm_Lab4
// Program Description: Modify your Lab 2 submission so that it ask the user to enter the names and grades
//                      of three students (instead of one). You should design a new class to store the information of each of the
//                      three students, complete with attributes for Names, Grades, and Averages and properties for GETting
//                      and SETting those values, Constructors for initializing new Student objects with either no information or
//                      their name already set, and a method for calculating and displaying the average.
//
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CProm_Lab4
{
    class CProm_Lab4
    {
        static void Main(string[] args)
        {
     
            StreamWriter sw = new StreamWriter("lab4_Results.txt"); //Pass the filepath and filename to the StreamWriter Constructor
                                                                    //Text file will be created in in the working directory <project name>/bin/Debug/net7.0

            for (int i = 1; i <=3; i++)  // use for loop to build 3 student objects
            {
                Console.Write("Please enter student #{0}'s name: ", i); // Ask for user to input name
                string name = Console.ReadLine();

                Console.Write("Please enter grade #1 for {0}: ", name);     // ask for user input.
                float grade1 = float.Parse(Console.ReadLine());             // read user input.
                Console.Write("Please enter grade #2 for {0}: ", name);     
                float grade2 = float.Parse(Console.ReadLine());
                Console.Write("Please enter grade #3 for {0}: ", name);
                float grade3 = float.Parse(Console.ReadLine());

                StudentA students = new StudentA(name, grade1, grade2, grade3);

                
                students.DisplayAverage();  // call student method to display the average
                Console.WriteLine();    // add extra line on screen
                sw.WriteLine($"The average score of {name} is {students.ReturnAverage()}."); // write line to .txt file.

            }

        
            
            
            sw.Close(); //Close the file

            Console.Write("\n\n Press any key to continue...");
            Console.ReadKey();

        }
    }
}
