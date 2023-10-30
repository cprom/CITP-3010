using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Demo
{
    class Student
    {
        // ATTRIBUTES

        private string firstName;                                   // A private variable, accessible on within the Student class, to store the first name.
        private string lastName;                                    // As above, for last name.
        private double gpa;                                         // As above, for GPA. These variables should be accessed, internally and externally,
                                                                    // through the accessor GET and SET methods in the associated properties below.
        // PROPERTIES

        public string FirstName                                     // A property associated with the firstName attribute above.
        {
            get                                                     // This get method will be used anytime we attempt to access the value stored in the
            {                                                       // via this property. Because we are working only with simple types, we do something
                return firstName;                                   // such as return firstName. For more complicated types later, this may be more complicated.
            }
            set                                                     // The set method will be used anytime we attempt to save a value into this property.
            {                                                                   
                firstName = value;                                  // With our simple types, we can do this as simply as assigning the keyword VALUE to the
            }                                                       // associated variable.    
        }

        public string LastName                                      // A property associated with (and used for GETting and SETting) the lastName attribute.
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public double GPA                                           // A property associated with (and used for GETting and SETting) the gpa attribute.
        {
            get
            {
                return gpa;
            }
            set
            {
                gpa = value;
            }
        }


        // CONSTRUCTORS

        public Student()                                            // Default constructor, for creating a blank Student object.
        {
        }

        public Student(string first, string last)                   // Overloaded Constructor to set first and last name initially.
        {
            FirstName = first;                                      // Note use of property for set accessor, despite the attribute being a class member.
            LastName = last;                                        // This ensures we know exactly how our data is being manipulated.
        }

        public Student(string first, string last, double gpa)       // Overloaded Constructor to set first and last name, as well as GPA initially.
        {
            FirstName = first;
            LastName = last;
            GPA = gpa;
        }

        // METHODS

        public void DisplayStudentInfo()
        {
            Console.Write("\n");
           
            Console.WriteLine("Student Name: {0} {1} ", FirstName, LastName);
            Console.WriteLine("GPA: {0}", GPA);
        }

    }
}
