using System;
using System.Collections.Generic;
using System.Text;

//1.Create at least 3 classes Buyer,Salesman,RetailSalesPerson,Re-helper
namespace CTIS479_Homework_1
{
    public class Buyer
    {
        private string firstName;
        private string lastName;

        // 3.There has to be at least one has-a relation between the classes.
        public Address address;//Employee HAS-A Address  

        public void GetFullname()
        {
            Console.WriteLine("Hi! Mi name is {0} {1}, and I want a car", this.firstName, this.lastName);
        }
        public Buyer(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public Buyer(string firstName, string lastName, Address address) 
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
        }

        public void display()
        {
            Console.WriteLine("Addess of: "+this.firstName+" "+this.lastName+". is this: "+this.address.addressLine+", " + this.address.city + ", " + this.address.state+".");
        }
    }
}
