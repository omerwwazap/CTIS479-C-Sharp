using System;
using System.Collections.Generic;
using System.Text;

//1.Create at least 3 classes Buyer,Salesman,RetailSalesPerson,Re-helper
//2.Add is-a relation between the classes, there has to be at least 3 level of inheritance
namespace CTIS479_Homework_1
{
    public class RetailSalesPerson : Salesman, SelfDeveloping
    {
        public RetailSalesPerson(string firstName, string lastName) : base(firstName, lastName) { }


        public RetailSalesPerson(string firstName, string lastName, int age) : base(firstName, lastName, age) { }


        public void Car_Develop()
        {
            if (!getAge.Equals("0"))
            {
                Console.WriteLine("Hi! Mi name is {0} and my age: {1}, and Our Compay developed this car in house and took 20 years :(", this.Fullname, this.getAge);
            }
            else{
                Console.WriteLine("Hi! Mi name is {0}, and Our Compay developed this car in house and took 20 years :(", this.Fullname);
            }

        }

        protected override void Tell_about_car()
        {
            Console.WriteLine("It goes very fast");
        }

        protected override void Close()
        {
            Console.WriteLine("Buy this car!");
        }

        protected override void Talk()
        {
            Console.WriteLine("You look like you need a car my man");
        }
    }
}
