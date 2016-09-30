using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1;
            p1 = new Person();

            //what is your first name?
            p1.FirstName = "Terrence";

            //what is your last name?
            p1.LastName = "Myhand";

            //what is your age?
            p1.Age = 34;

            p1.spouse = new Person();
            //what is your spouse's first name?
            p1.spouse.FirstName = "Momo";

            //what is your spouse's last name?
            p1.spouse.LastName = "Murasaki";

            //what is your spouse's age?
            p1.spouse.Age = 25;

            p1.spouse.LastName = p1.LastName;
            p1.spouse.spouse = p1;

            Person p2;
            p2 = new Person();

            //what is your first name?
            p2.FirstName = "Akari";

            //what is your last name?
            p2.LastName = "Murasaki";

            //what is your age?
            p2.Age = 31;
                            
            p2.spouse = new Person();
            //what is your spouse's first name?
            p2.spouse.FirstName = "Kintaro";

            //what is your spouse's last name?
            p2.spouse.LastName = "Okami";

            //what is your spouse's age?
            p2.spouse.Age = 33;

            p2.spouse.LastName = p2.LastName;
            p2.spouse.spouse = p2; 


        }
    }
}
