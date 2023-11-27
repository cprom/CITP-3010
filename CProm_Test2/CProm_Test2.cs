/////////////////////////////////////////////////////////////////////////////////////
//
// Name: Chen Prom 
// Date: 11/18/2023
// Class: CITP-3010
// Semester: FALL 2023
// Instructor’s Name:NICOLAS GUTIERREZ
//
// Program Title:CProm_Test2
// Program Description:   Program in that calculates a customer's monthly bill. It should ask the user to enter the
//                        customer name, which package the customer has purchased, and how many hours were used. The
//                        program should then create a bill (format it like bill) that includes the input information and the total
//                        amount due, then display the bill on screen.
//
/////////////////////////////////////////////////////////////////////////////////////


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CProm_Test2

{
    class CProm_Test2
    {
         static void PrintBill(string userName, char package, int hoursUsed, double amount)  //function to print out the bill
            {
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("Bill For: " + userName);
                Console.WriteLine("Package: " + package);
                Console.WriteLine("Hours used: " + hoursUsed);
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("Total Amount Due: $" + amount);
                Console.WriteLine("--------------------------------------------------------");
            }



        static void Main(string[] args)
        {
            
            bool loopProgram = true;  // variable used for restarting program.
            

            do
            {
               
                Console.Write("Please enter your name: "); // Ask for user to input name
                string userName = Console.ReadLine(); // reading name input and storing to variable 

                Console.Write("Enter the Package you purchased (A, B, C): ");
                char package = Convert.ToChar(Console.ReadLine());
                while (package != 'A' && package != 'a' && package != 'B' && package != 'b' && package != 'C' && package != 'c') //validate the user input for packages.
                {                                                                                                                
                    Console.Write("Please Enter A, B, or C: ");
                    package = Convert.ToChar(Console.ReadLine());
                   
                }

                Console.Write("Enter Hours used: ");
                int hoursUsed = Convert.ToInt32(Console.ReadLine());

                double amount = 0;

                if (package == 'A' || package == 'a')
                {

                    if (hoursUsed > 5)
                    {
                        double overage = ((hoursUsed - 5) * 60) * 0.08;
                        amount = 9.95 + overage;
                        PrintBill(userName, package, hoursUsed, amount);
                    }
                    else
                    {
                        amount = 9.95 ;
                        PrintBill(userName, package, hoursUsed, amount);
                    }

                    // display how much money customer would save if they pick package A
                    switch (package)
                    {
                        case 'a':
                        case 'A':
                            if (amount < calculateAmountB(hoursUsed))
                            {
                                Console.WriteLine("");
                            }
                            else
                            {
                                Console.WriteLine($"Package B Savings: {amount - calculateAmountB(hoursUsed)}");
                            }

                            if (amount < calculateAmountC())
                            {
                                Console.WriteLine("");
                            }
                            else
                            {
                                Console.WriteLine($"Package C Savings: {amount - calculateAmountC()}");
                            }
                            break;
                        case 'b':
                        case 'B':
                            if (amount < calculateAmountC())
                            {
                                Console.WriteLine("");
                            }
                            else
                            {
                                Console.WriteLine($"Package C Savings: {amount - calculateAmountC()}");
                            }
                            break;
                        default:
                            Console.Write("");
                            return;
                    }
                }
                else if (package == 'B' || package == 'b')
                {
                    if (hoursUsed > 10)
                    {
                        double overage = ((hoursUsed - 10) * 60) * 0.06;
                        amount = 14.95 + overage;
                        PrintBill(userName, package, hoursUsed, amount);
                    }
                    else
                    {
                        amount = 14.95;
                        PrintBill(userName, package, hoursUsed, amount);
                    }

                    // display how much money customer would save if they pick package B
                    switch (package)
                    {
                        case 'a':
                        case 'A':
                            if (amount < calculateAmountB(hoursUsed))
                            {
                                Console.WriteLine("");
                            }
                            else
                            {
                                Console.WriteLine($"Package B Savings: {amount - calculateAmountB(hoursUsed)}");
                            }

                            if (amount < calculateAmountC())
                            {
                                Console.WriteLine("");
                            }
                            else
                            {
                                Console.WriteLine($"Package C Savings: {amount - calculateAmountC()}");
                            }
                            break;
                        case 'b':
                        case 'B':
                            if (amount < calculateAmountC())
                            {
                                Console.WriteLine("");
                            }
                            else
                            {
                                Console.WriteLine($"Package C Savings: {amount - calculateAmountC()}");
                            }
                            break;
                        default:
                            Console.Write("");
                            return;
                    }

                }
                else if (package == 'C' || package == 'c')
                {
                    {
                        amount = 19.95;
                        PrintBill(userName, package, hoursUsed, amount);
                    }

                }

                static double calculateAmountB(int hoursUsed)
                {
                    double amount = 0;
                    if (hoursUsed > 10)
                    {
                        double overage = ((hoursUsed - 10) * 60) * 0.06;
                        amount = 14.95 + overage;
                        
                    }
                    else
                    {
                        amount = 14.95;
                        
                    }
                    return amount;
                }

                static double calculateAmountC()
                {
                    return 19.95;
                }


                Console.Write("Would you like check another Package? (Y/N) ");
                char answer = Convert.ToChar(Console.ReadLine());
                if (answer == 'N' || answer == 'n')
                {
                    loopProgram = false;
                    using (StreamWriter writer = new StreamWriter("MyBill.txt")) // write bill to file when user press N/n
                    {
                        writer.WriteLine("--------------------------------------------------------");
                        writer.WriteLine("Bill For: " + userName);
                        writer.WriteLine("Package: " + package);
                        writer.WriteLine("Hours used: " + hoursUsed);
                        writer.WriteLine("--------------------------------------------------------");
                        writer.WriteLine("Total Amount Due: $" + amount.ToString("n2"));
                        writer.WriteLine("--------------------------------------------------------");
                        writer.WriteLine("--------------------------------------------------------");
                        writer.WriteLine($"Package B savings {amount - calculateAmountB(hoursUsed)}");
                        writer.WriteLine($"Package C savings {amount - calculateAmountC()}");
                        writer.WriteLine("--------------------------------------------------------");
                    }
                }

            } while (loopProgram);

            Console.Write("Press any key to continue.  .  .");
            Console.ReadKey();
        }

    }

}




