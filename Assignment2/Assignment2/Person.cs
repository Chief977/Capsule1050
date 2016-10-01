namespace Assignment2
{
    class Person
    {
        public int Age;
        public string FirstName;
        public string LastName;
        public Person Spouse;
        public string AverageAge;

        public static double SumOfAllAges = 124;
        
       
                
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public void PrintFullNameAndAge()

        {
            System.Console.WriteLine(FirstName);
            System.Console.WriteLine(LastName);
            System.Console.WriteLine(Age);
        }
    }
}  
    