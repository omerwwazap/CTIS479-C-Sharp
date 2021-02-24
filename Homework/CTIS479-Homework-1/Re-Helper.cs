using System;
using System.Collections.Generic;
using System.Text;

//1.Create at least 3 classes Buyer,Salesman,RetailSalesPerson,Re-helper
//2.Add is-a relation between the classes, there has to be at least 3 level of inheritance
namespace LeventDurdali_HomeWork1
{
    class Re_Helper : RetailSalesPerson
    {
        public Re_Helper(string firstName, string lastName) : base(firstName, lastName) { }

        public Re_Helper(string firstName, string lastName, int age) : base(firstName, lastName, age) { }

        public override string ToString()
        {
            return base.ToString();
        }

        protected override void Close()
        {
            base.Close();
        }

        protected override void Talk()
        {
            Console.WriteLine("You look like you need a car my man - by helper");
        }

        protected override void Tell_about_car()
        {
            Console.WriteLine("It goes very fast - by helper");
        }
    }
}
