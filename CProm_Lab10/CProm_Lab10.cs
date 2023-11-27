/////////////////////////////////////////////////////////////////////////////////////
//
// Name: Chen Prom 
// Date: 11/12/2023
// Class: CITP-3010
// Semester: FALL 2023
// Instructor’s Name:NICOLAS GUTIERREZ
//
// Program Title: CProm_Lab10
// Program Description: Console Program that will as the user for a number and will
//                      calculate and display teh values of teh Fibonacci sequence
//                      to the nth position.
//                      
/////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CProm_Lab10
{
    class CProm_Lab10
    {
        static void Main(string[] args)
        {
            int num; // declare variable to store number
            Console.WriteLine("Enter a number: ");
            num = int.Parse(Console.ReadLine());  // read input from user

            // Calculate the Fibonacci sequence to the n position
            int[] fib = new int[num + 1];
            fib[0] = 0;
            fib[1] = 1;
            for (int i = 2; i <= num; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }

            // Display the Fibonacci sequence
            Console.WriteLine("The Fibonacci sequence to the {0}th position are: ", num);
            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine(fib[i]);
            }
            // **Challenge Write the Fibonacci sequence to a file called fibonacci.txt in bin/debug/net7.0
            using (StreamWriter writer = new StreamWriter("fibonacci.txt"))
            {
                for (int i = 0; i <= num; i++)
                {
                    writer.WriteLine(fib[i]);
                }
            }
        }
    }
}



