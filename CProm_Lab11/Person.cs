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
//
/////////////////////////////////////////////////////////////////////////////////////


using System;
namespace CProm_Lab11
{
	 class Person
	{
		//Atrribute
		private string firstName;
		private string lastName;
		private int dayOfBirth;
		private int monthOfBirth;
		private int yearOfBirth;
		private int age;

		// Default Constructor
		public Person()
		{
		}

		// Constructor with all atrribute
		public Person(string firstName, string lastName, int dayOfBirth, int monthOfBirth, int yearOfBirth)
		{
			FirstName = firstName;
			LastName = lastName;
			DayOfBirth = dayOfBirth;
			MonthOfBirth = monthOfBirth;
			YearOfBirth = yearOfBirth;
			calculateAge();  // Challenge
		}

		// Constructor to set First Name and Last Name
		public Person(string firstName, string lastName)
		{
			FirstName = firstName;
			LastName = lastName;
		}

        // Constructor to set First Name, Last Name, and Age.
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
			Age = age;
        }

		public string FirstName
		{
			get
			{
				return firstName;
			}
			set
			{
				firstName = value;
			}
		}

        public string LastName
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

		public int DayOfBirth
		{
			get
			{
				return dayOfBirth;
			}
			set
			{
				dayOfBirth = value;
			}
		}

        public int MonthOfBirth
        {
            get
            {
                return monthOfBirth;
            }
            set
            {
                monthOfBirth = value;
            }
        }

        public int YearOfBirth
        {
            get
            {
                return yearOfBirth;
            }
            set
            {
                yearOfBirth = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

		// Check if person is an adult.
		public bool IsAdult()
		{
            if (age >= 18)
            {
                Console.WriteLine(true);
                return true;
            }
            else
            {
                Console.WriteLine(false);
                return false;
            }
                
		}

		// Check Western Sun Sign of the person
		public string getWesternSunSign()
		{
			if (monthOfBirth == 3 && dayOfBirth >= 21 || monthOfBirth == 4 && dayOfBirth <= 19)
			{
				Console.WriteLine("Aries");
				return "Aries";
			}
			else if (monthOfBirth == 4 && dayOfBirth >= 20 || monthOfBirth == 5 && dayOfBirth <= 20)
			{
                Console.WriteLine("Taurus");
                return "Taurus";
			}
			else if(monthOfBirth == 5 && dayOfBirth >= 21 || monthOfBirth == 6 && dayOfBirth <= 21)
			{
                Console.WriteLine("Gemini");
                return "Gemini";
			}
            else if (monthOfBirth == 6 && dayOfBirth >= 22|| monthOfBirth == 7 && dayOfBirth <= 22)
            {
                Console.WriteLine("Cancer");
                return "Cancer";
            }
            else if (monthOfBirth == 7 && dayOfBirth >= 23 || monthOfBirth == 8 && dayOfBirth <= 22)
            {
                Console.WriteLine("Leo");
                return "Leo";
            }
            else if (monthOfBirth == 8 && dayOfBirth >= 23 || monthOfBirth == 9 && dayOfBirth <= 22)
            {
                Console.WriteLine("Virgo");
                return "Virgo";
            }
            else if (monthOfBirth == 9 && dayOfBirth >= 23 || monthOfBirth == 10 && dayOfBirth <= 23)
            {
                Console.WriteLine("Libra");
                return "Libra";
            }
            else if (monthOfBirth == 10 && dayOfBirth >= 24 || monthOfBirth == 11 && dayOfBirth <= 22)
            {
                Console.WriteLine("Scorpio");
                return "Scorpio";
            }
            else if (monthOfBirth == 11 && dayOfBirth >= 23 || monthOfBirth == 12 && dayOfBirth <= 21)
            {
                Console.WriteLine("Sagittarius");
                return "Sagittarius";
            }
            else if (monthOfBirth == 12 && dayOfBirth >= 22 || monthOfBirth == 1 && dayOfBirth <= 19)
            {
                Console.WriteLine("Capricorn");
                return "Capricorn";
            }
            else if (monthOfBirth == 1 && dayOfBirth >= 20 || monthOfBirth == 2 && dayOfBirth <= 18)
            {
                Console.WriteLine("Aquarius");
                return "Aquarius";
            }
            else if (monthOfBirth == 2 && dayOfBirth >= 19 || monthOfBirth == 3 && dayOfBirth <= 20)
            {
                Console.WriteLine("Pisces");
                return "Pisces";
            }
            else
            { 
                Console.WriteLine("Unable to find sign. Missing Birth date values.");
                return "Unable to find sign. Missing Birth date values.";
            }
        }

        // Challenge Calculate the age of the person
        public void calculateAge() 
        {
            int currentDay = DateTime.Now.Day;  // Get the day
            int currentMonth = DateTime.Now.Month; // Get the month
            int currentYear = DateTime.Now.Year; // get the year


            if (monthOfBirth == 0 || dayOfBirth == 0 || yearOfBirth == 0)
            {
                Console.WriteLine("Missing Birth Date values.");
            }
            else
            {
                if (currentDay >= dayOfBirth && currentMonth >= monthOfBirth && currentYear >= yearOfBirth)
                {
                    age = currentYear - yearOfBirth;
                    Console.WriteLine(age);
                }
                else if (currentMonth > monthOfBirth && currentYear >= yearOfBirth)
                {
                    age = currentYear - yearOfBirth;
                    Console.WriteLine(age);
                }
                else if (dayOfBirth < currentDay && currentMonth == monthOfBirth && currentYear >= yearOfBirth)
                {
                    age = (currentYear - yearOfBirth);
                    Console.WriteLine(age);
                }
                else if (dayOfBirth < currentDay && monthOfBirth > currentMonth)
                {
                    age = (currentYear - yearOfBirth) - 1;
                    Console.WriteLine(age);
                }
                else if (dayOfBirth > currentDay && monthOfBirth > currentMonth && currentYear > yearOfBirth)
                {
                    age = (currentYear - yearOfBirth) - 1;
                    Console.WriteLine(age);
                }
                else if (dayOfBirth > currentDay && monthOfBirth == currentMonth)
                {
                    age = (currentYear - yearOfBirth) - 1;
                    Console.WriteLine(age);
                }
            }
          

            
        }

        // get Chinese Astrological sign of the person
        public string getChineseAstroSign()
        {
            switch (yearOfBirth)
            {
                case 1924:
                case 1936:
                case 1948:
                case 1960:
                case 1972:
                case 1984:
                case 1996:
                case 2008:
                case 2020:
                    Console.WriteLine("Rat");
                    return "Rat";
                    break;
                case 1925:
                case 1937:
                case 1949:
                case 1961:
                case 1973:
                case 1985:
                case 1997:
                case 2009:
                case 2021:
                    Console.WriteLine("Ox");
                    return "Ox";
                    break;
                case 1926:
                case 1938:
                case 1950:
                case 1962:
                case 1974:
                case 1986:
                case 1998:
                case 2010:
                case 2022:
                    Console.WriteLine("Tiger");
                    return "Tiger";
                    break;
                case 1927:
                case 1939:
                case 1951:
                case 1963:
                case 1975:
                case 1987:
                case 1999:
                case 2011:
                case 2023:
                    Console.WriteLine("Rabbit");
                    return "Rabbit";
                    break;
                case 1928:
                case 1940:
                case 1952:
                case 1964:
                case 1976:
                case 1988:
                case 2000:
                case 2012:
                case 2024:
                    Console.WriteLine("Dragon");
                    return "Dragon";
                    break;
                case 1929:
                case 1941:
                case 1953:
                case 1965:
                case 1977:
                case 1989:
                case 2001:
                case 2013:
                case 2025:
                    Console.WriteLine("Snake");
                    return "Snake";
                    break;
                case 1930:
                case 1942:
                case 1954:
                case 1966:
                case 1978:
                case 1990:
                case 2002:
                case 2014:
                case 2026:
                    Console.WriteLine("Horse");
                    return "Horse";
                    break;
                case 1931:
                case 1943:
                case 1955:
                case 1967:
                case 1979:
                case 1991:
                case 2003:
                case 2015:
                case 2027:
                    Console.WriteLine("Sheep");
                    return "Sheep";
                    break;
                case 1932:
                case 1944:
                case 1956:
                case 1968:
                case 1980:
                case 1992:
                case 2004:
                case 2016:
                case 2028:
                    Console.WriteLine("Monkey");
                    return "Monkey";
                    break;
                case 1933:
                case 1945:
                case 1957:
                case 1969:
                case 1981:
                case 1993:
                case 2005:
                case 2017:
                case 2029:
                    Console.WriteLine("Rooster");
                    return "Rooster";
                    break;
                case 1934:
                case 1946:
                case 1958:
                case 1970:
                case 1982:
                case 1994:
                case 2006:
                case 2018:
                case 2030:
                    Console.WriteLine("Dog");
                    return "Dog";
                    break;
                case 1935:
                case 1947:
                case 1959:
                case 1971:
                case 1983:
                case 1995:
                case 2007:
                case 2019:
                case 2031:
                    Console.WriteLine("Pig");
                    return "Pig";
                    break;
                default:
                    Console.WriteLine("Year Out of Range.");
                    return "Year out of Range.";
            }
        }
    }
}

