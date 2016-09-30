namespace Assignment2
{
    class Person
    {
        public int Age;
        public string FirstName;
        public string LastName;
        public Person Spouse;

        public static double SumOfAllAges;

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
        public void PrintNameAndAge()
        {System.Console.WriteLine(FirstName + LastName + SumOfAllAges); }
           }
        }
    