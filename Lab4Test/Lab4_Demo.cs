using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Demo
{
    class Lab3_Demo
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Stephen", "Spielberg", 4.0);            // Lets create some objects of type student.
            Student student2 = new Student("Eli", "Roth");                          // Each one of these uses a different Constructor.
            Student student3 = new Student();

            student1.DisplayStudentInfo();                                          // Calling the DisplayStudentInfo method for each student we've created.
            student2.DisplayStudentInfo();                                          // student2 and student3 have some unknown information, so those areas
            student3.DisplayStudentInfo();                                          // will display the default value that all instance variables have.

            Console.WriteLine("Let's make some changes...\n\n");

            student2.GPA = 3.6;                                                     // Through the use of our public properties, we can change the values
            student3.FirstName = "Quentin";                                         // of our students attributes. 
            student3.LastName = "Tarantino";

            student1.DisplayStudentInfo();                                          // Let's redisplay the student info, so we can see what changes we've made.
            student2.DisplayStudentInfo();
            student3.DisplayStudentInfo();

            Console.Write("\n\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
