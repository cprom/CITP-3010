/////////////////////////////////////////////////////////////////////////////////////
//
// Name: Chen Prom 
// Date: 11/26/2023
// Class: CITP-3010
// Semester: FALL 2023
// Instructor’s Name:NICOLAS GUTIERREZ
//
// Program Title: CProm_Lab12
// Program Description: A program that calculates a contestant's score based on the scores from five judges. 
//
/////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Project
{
    //Challenge
    public class CalculateAverage
    {
        public static void FindMaxAndMin(double score1, double score2, double score3, double score4, double score5, ref double maxScore, ref double minScore)
        {
            double[] scoresArray = { score1, score2, score3, score4, score5 };  //initialize an array to store the judges scores

            maxScore = scoresArray.Max(); // use Max() method to find biggest number
            minScore = scoresArray.Min(); // use Min() method to find smalles number

        }

        public static double Avg5MinusMaxMin(double score1, double score2, double score3, double score4, double score5, double maxScore, double minScore)
        {
            FindMaxAndMin(score1, score2, score3, score4, score5, ref minScore, ref maxScore);

            double average = (score1 + score2 + score3 + score4 + score5 - minScore - maxScore) / 3;

            return average;
        }
    }

   
    
    
    class CProm_Lab12
    {
        
        static void Main(string[] args)
        {
            double score1, score2, score3, score4, score5; // The judges' scores
            double avg; // The average scores excluding maximum and minimum
            double minScore = 0;
            double maxScore = 0;

            // Print the welcome message
            Console.WriteLine("This program calculates the contestant's score based on ");
            Console.WriteLine("scores from 5 judges. The highest and lowest scores are dropped.");


            // Get the judges' scores from console input
            score1 = getDouble0to10("Score from judge 1: ");
            Console.Write("\n");
            score2 = getDouble0to10("Score from judge 2: ");
            Console.Write("\n");
            score3 = getDouble0to10("Score from judge 3: ");
            Console.Write("\n");
            score4 = getDouble0to10("Score from judge 4: ");
            Console.Write("\n");
            score5 = getDouble0to10("Score from judge 5: ");

            // Find the average with the maximum and minimum scores dropped
            avg = CalculateAverage.Avg5MinusMaxMin(score1, score2, score3, score4, score5, minScore, maxScore);

            // Print the average to console output
            Console.WriteLine("\nThe contestant's score is: {0}", avg);


            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }

        //
        // This function gets a double between 0 and 100 from console input
        //
        // DO NOT MODIFY THIS FUNCTION
        //
        static double getDouble0to10(string message)
        {
            double num = 0;
            string tempInput;
            bool isValid = true;

            Console.Write(message);        

            // Check for Valid Input
            // This is a complex bit of input validation code.
            // The do while loop maintains that we keep asking for input until we receive valid input.
            do
            {
                if (!isValid || Math.Floor(num) < 0 || Math.Ceiling(num) > 10) 
                // Our isValid boolean variable starts at true, so this won't execute on the first run.
                // On subsequent runs, if the input was invalid, it will tell us so.
                {
                    Console.WriteLine("You entered invalid input.");
                    Console.Write("Enter a double between 0 and 10: ");
                }

                // Here we read the input from the user.
                tempInput = Console.ReadLine();

                // This statement checks if the text they entered CAN be converted to a double. TryParse returns true if the string
                // provided can be converted to a double (you must provide a string, and an out variable of the correct return type.
                isValid = double.TryParse(tempInput, out num);

                // If isValid is true, then our number was correct, so we convert the string to a number and store it in our double.
                if (isValid)
                    num = Convert.ToDouble(tempInput);

                // isValid here is only false if the TryParse function failed (meaning the user entered something other than a number.
                // Additionally, Floor will reduce the number to the closest integer rounding down, and Ceiling to the closest rounding up.
                // Checking doubles is hard, and floor and num will make sure that we get an accurate measure.
            } while (!isValid || Math.Floor(num) < 0 || Math.Ceiling(num) > 10);


            // Return the number input by the user
            return num;

        } // end getDouble0to10 function


        ////////////////////////////////
        // Start of your code

        //
        // This function finds the minimum and maximum of a series of 5 numbers
        // This function should have a void return type.
        // You must use some reference parameters for this function.
        // Remember that inside this class, because it is not instantiated, 
        // we need to define these functions as static.
        //
        // Write this function
        //

        // ***** Code below is for the original lab it is commented out because the program is utilizing the class located at the top of the page per the challenge ***.

        //static void findMaxAndMin(double score1, double score2, double score3, double score4, double score5, ref double maxScore, ref double minScore)
        //{
        //    double[] scoresArray = { score1, score2, score3, score4, score5 };  //initialize an array to store the judges scores

        //    maxScore = scoresArray.Max(); // use Max() method to find biggest number
        //    minScore = scoresArray.Min(); // use Min() method to find smalles number

        //}


        //
        // Find the average of 5 numbers excluding the minimum and maximum
        // If there is more than one number with the minimum or maximum value,
        // only exclude the number one time. For example, if the numbers are:
        // 4.5 6.7 2.3 7.8 2.3, the average is calculated using the numbers:
        // 4.5 6.7 2.3.
        //
        // This function must call the above function that finds the minimum and maximum
        // values in a series of 5 numbers.
        //
        // This function does not use reference parameters
        //
        // Write this function
        //

        
        //static double avg5MinusMaxMin(double score1, double score2, double score3, double score4, double score5,  double maxScore,  double minScore)
        //{
        //    findMaxAndMin(score1, score2, score3, score4, score5, ref minScore, ref maxScore);

        //    double average = (score1 + score2 + score3 + score4 + score5 - minScore - maxScore) / 3;

        //    return average;
        //}

        // End of your code
        ////////////////////////////////

    }
}
