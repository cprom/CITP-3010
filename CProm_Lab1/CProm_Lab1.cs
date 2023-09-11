
/////////////////////////////////////////////////////////////////////////////////////
//
// Name: Chen Prom 
// Date: 9/9/2023
// Class: CITP-3010
// Semester: FALL 2023
// Instructor’s Name:NICOLAS GUTIERREZ
//
// Program Title: CProm_Lab1
// Program Description: A console program to print out my name and what lab number using Console.WriteLine().
//
/////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class CProm_Lab1
    {
        static void Main(string[] args)
        {

            string name = "Chen Prom";
            int labNumber = 1;

            Console.WriteLine("Hello World!");     

            Console.WriteLine($"My name is {name}.");
            Console.WriteLine($"This    is     Lab {labNumber}.");
                                                                                
            Console.Write("\n\n");                  

            Console.WriteLine("  CCCCCCCCC    PPPPPPPPPP     ");      
            Console.WriteLine(" CCCCCCCC     PPPPPPPPPPPP    ");      
            Console.WriteLine("CCC           PPP       PPP   ");
            Console.WriteLine("CC            PPP       PPP   ");
            Console.WriteLine("CC            PPPPPPPPPPPP    ");
            Console.WriteLine("CC            PPPPPPPPPP      ");
            Console.WriteLine("CCC           PPP             ");
            Console.WriteLine(" CCCCCCCC     PPP             ");
            Console.WriteLine("  CCCCCCCC    PPP             ");

        }
    }
}
