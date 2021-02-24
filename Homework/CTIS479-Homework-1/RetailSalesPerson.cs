using System;
using System.Collections.Generic;
using System.Text;

namespace CTIS479_Homework_1
{
    public class RetailSalesPerson : Salesman, SelfDeveloping
    {
        public RetailSalesPerson(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public RetailSalesPerson(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {
        }

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
