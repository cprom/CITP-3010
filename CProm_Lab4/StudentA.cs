using System;
namespace CProm_Lab4
{
	class StudentA
	{
		// Atrributes
		private string name = string.Empty;  //variable to store student's first name
		private float grade1;  // variable to store student's grade 1
		private float grade2;  // variable to store student's grade 2
        private float grade3;  // variable to store student's grade 3
        private float average;     // variable to store student's average


		// Properties
		public string Name	// property associated with the student's name.
		{
			get
			{
				return name;  //getter method for name.
			}
			set
			{
				name = value;	// setter method for name.
			}
		}

		public float Grade1		// property associated with Grade1. 
		{
			get
			{
				return grade1;		// getter method for grade1.
			}
			set
			{
				grade1 = value;		// setter method for grade1
			}
		}

        public float Grade2			// property associated with Grade2.
        {
            get
            {
                return grade2;		// getter method for grade2.
            }
            set
            {
                grade2 = value;		// setter method for grade2.
            }
        }

        public float Grade3		//property associated with Grade3.
        {
            get
            {
                return grade3;		//getter method for grade3.
            }
            set
            {
                grade3 = value;		//setter method for grade3.
            }
        }

        public float Average		// property associated with Average.
		{
			get
			{
				return average;		//getter method for average.
			}
			set
			{
                average = value;	//setter method for average.
            }
		}

		// Constructors

		public StudentA()	// Default constructor, for creating a blank Student object.
		{
		}

		public StudentA(string name)    // Overloaded Constructor to set name initially.
        {
			Name = name;
		}

		public StudentA(string name, float grade1, float grade2, float grade3) // Overloaded Constructor to set name and grades initially.
        {
			Name = name;
			Grade1 = grade1;
			Grade2 = grade2;
			Grade3 = grade3;
		}

		// Methods

		private string CalculateAndDisplayGradeAverage()	//method to calculate average
		{
            float average = (grade1 + grade2 + grade3) / 3;	// calculate grade average
            string modifiedAverage = string.Format("{0:0.00}", average); // create a string that display 2 decimal places
			return modifiedAverage;
        }
		 
		public void DisplayAverage()	// method to display student name and average
		{
			Console.WriteLine("{0}'s average is {1}", Name, CalculateAndDisplayGradeAverage());
		}

		public string ReturnAverage()  // method to return student's average to be used in writing to .txt file.
		{
            return CalculateAndDisplayGradeAverage();
        }

    }
}

