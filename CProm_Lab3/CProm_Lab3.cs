/////////////////////////////////////////////////////////////////////////////////////
//
// Name: Chen Prom 
// Date: 9/24/2023
// Class: CITP-3010
// Semester: FALL 2023
// Instructor’s Name:NICOLAS GUTIERREZ
//
// Program Title:CProm_Lab3
// Program Description: A program that takes input from user and writes it to a .txt file.
//
/////////////////////////////////////////////////////////////////////////////////////

using System;


namespace ConsoleApplication1
{
    class CProm_Lab3
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Thank you for Registering.");//Display Greeting

            Console.Write("Please enter your name: "); // Ask for user to input name
            string userName = Console.ReadLine(); // reading name input and storing to variable 

            Console.Write("Enter your gender (m/f): "); // Ask for user to input gender
            string gender = Console.ReadLine(); // reading gender input and storing to variable 

            Console.Write("Enter your Age: "); // Ask for user to input Age
            int age = int.Parse(Console.ReadLine());   // reading age input and storing to variable 
            Console.Write("Enter your salary: ");  // Ask for user to input salary
            double salary = double.Parse(Console.ReadLine());     // reading salary input and storing variable

            Console.WriteLine("\n"); // add line
            Console.WriteLine("Data is being saved to file."); // Display message to let user know data is being save to a file.

            StreamWriter sw = new StreamWriter("userdata.txt"); //Pass the filepath and filename to the StreamWriter Constructor
                                                                //Text file will be created in in the working directory <project name>/bin/Debug/net7.0

            sw.WriteLine(userName);  //write userName to file
            sw.WriteLine(gender);   //write gender to file
            sw.WriteLine(age);      //write age to file
            sw.WriteLine(salary);   //write salary to file
            sw.Close();     // close the file

            Console.WriteLine("Save completed.\n");  // display save complete message.

            Console.WriteLine("Performing Test Read: \n"); //display message
            StreamReader sr = new StreamReader("userdata.txt"); //Pass the filepath and filename to the StreamReader Constructor
            
            string text = sr.ReadToEnd(); // variable to store what is read from file
            sr.Close(); // close the file
            Console.WriteLine(text); // display content of file

        }
    }
}


