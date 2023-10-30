/////////////////////////////////////////////////////////////////////////////////////
//
// Name: Chen Prom 
// Date: 10/14/2023
// Class: CITP-3010
// Semester: FALL 2023
// Instructor’s Name:NICOLAS GUTIERREZ
//
// Program Title: CProm_Lab6
// Program Description:  Simple program to diagnose medical conditions based on use input
//
/////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CProm_Lab6
{
    class CProm_Lab6
    {
        static void Main(string[] args)
        {
            // declare variables to store needed values.
            char fever;
            bool fever_ans;
            char stuffy_nose;
            bool stuffy_nose_ans;
            char rash;
            bool rash_ans;
            char ear_pain;
            bool ear_pain_ans;

            // Get fever input from user?
            Console.Write("Do you have a fever?(y/n) ");
            fever = Convert.ToChar(Console.ReadLine());
            if(fever == 'y' || fever == 'Y')                                //converts user input to boolean
            {
                fever_ans = true;
            }
            else
            {
                fever_ans = false;
            }

            // Get stuffy nose input from user?
            Console.Write("Do you have a stuffy nose?(y/n) ");
            stuffy_nose = Convert.ToChar(Console.ReadLine());
            if (stuffy_nose == 'y' || stuffy_nose == 'Y')                 //converts user input to boolean
            {
                stuffy_nose_ans = true;
            }
            else
            {
                stuffy_nose_ans = false;
            }

            // Get rash input from user.
            Console.Write("Do you have a rash?(y/n) ");
            rash = Convert.ToChar(Console.ReadLine());
            if (rash == 'y' || rash == 'Y')                             //converts user input to boolean
            {
                rash_ans = true;
            }
            else
            {
                rash_ans = false;
            }

            Console.Write("Does your ear hurts?(y/n) ");
            ear_pain = Convert.ToChar(Console.ReadLine());
            if (ear_pain == 'y' || ear_pain == 'Y')                     //converts user input to boolean
            {
                ear_pain_ans = true;
            }
            else
            {
                ear_pain_ans = false;
            }

            Console.WriteLine("");  // Add blankspace

            // Main logic, use if statements to make decisions based on user iput.
            if (!stuffy_nose_ans && !fever_ans)
            {
                Console.WriteLine("Diagnosis: You have Hypochondria.");
            }
            else if (!fever_ans && stuffy_nose_ans)
            {
                Console.WriteLine("Diagnosis: You have a Head Cold.");
            }
            else if (fever_ans && !rash_ans && ear_pain_ans)
            {
                Console.WriteLine("Diagnosis: You have the Flu.");
            }
            else if (fever_ans && rash_ans)
            {
                Console.WriteLine("Diagnosis: You have the Measles.");
            }
            else
            {
                Console.WriteLine("Diagnosis: Unclear head to the ER.");
            }
            {

            }


            Console.Write("Press any key to continue.  .  .");
            Console.ReadKey();
  
        }

   
    }
}


