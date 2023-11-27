/////////////////////////////////////////////////////////////////////////////////////
//
// Name: Chen Prom 
// Date: 11/18/2023
// Class: CITP-3010
// Semester: FALL 2023
// Instructor’s Name:NICOLAS GUTIERREZ
//
// Program Title:CProm_Lab11
// Program Description:  Create a class to define the object Person. Program to test
//                       functionality of the class.
//                       For the challenge component this week, write another method
//                       that will calculate the person’s age given their date of 
//                       birth and the current date.
//                       Person class is found in file Person.cs
//
/////////////////////////////////////////////////////////////////////////////////////


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CProm_Lab11
{
    class CProm_Lab11
    {
        static void Main(string[] args)
        {
            Person person = new Person("chen", "prom", 13, 12, 1981); // firstName, lastName, dayOfBirth, monthOfBirth, yearOfBirth

            person.IsAdult();
            person.getChineseAstroSign();
            person.getWesternSunSign();
                     
        }
    }
}

