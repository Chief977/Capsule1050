using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Person
    {
        public int Age;
        public string FirstName;
        public string LastName;
        public Person spouse;

        public static double SumOfAllAges;
        public string AverageAge;

        public class person
        {
            public string FirstName;
            public string LastName;
            public string GetFullName()
   
        {
            return this.FirstName + " " + LastName;
        }
            public void PrintNameAndAge()
            { System.Console.WriteLine(this.FirstName+this.LastName)
              System.Console.WriteLine("My name is" + this.GetFullName()
              System.Console.WriteLine("My age is" + this.Age);
              
            }            
    }       
}