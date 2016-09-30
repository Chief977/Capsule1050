namespace Assignment2
{
    class Person
    {
        public int Age;
        public string FirstName;
        public string LastName;
        public Person Spouse;
        public string AverageAge;

        public static double SumOfAllAges;
        
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public void PrintFullNameAndAge()

        {
        }
    }
}  
    