namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)

        {
            string firstName;
            string middleinitial;
            string lastName;
            string fullName;
            int age;
            bool isCitizen;
            bool canVote;
            int heightFeet;
            double heightInches;
            double totalHeightCM;
            
            firstName = "Terrence";
            middleinitial = "D";
            lastName = "Myhand";
            fullName = firstName + "" + middleinitial + "" + lastName;
            heightFeet = 5;
            heightInches = 8;
            totalHeightCM = (heightInches * 2.54) + heightFeet;
            age = 35;
            isCitizen = true;
            isCitizen = false;

            canVote = isCitizen = true && age >= 18;
            
            System.Console.WriteLine(fullName);
            System.Console.WriteLine(totalHeightCM);
            System.Console.WriteLine(canVote);



        }
    }
}

