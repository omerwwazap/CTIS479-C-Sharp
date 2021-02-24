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
        public Address address; //Buyer HAS-A Address  

        private Location now;
        public bool got_car;

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
        public Buyer(string firstName, string lastName, Address address, Location now, bool got_car)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.now = now;
            this.got_car = got_car;
        }

        public void Display()
        {
            Console.WriteLine("FirstName: " + this.firstName + " LastName: " + this.lastName + "'s addres is this: " + this.address.addressLine + ", " + this.address.city + ", " + this.address.state + ".");
            Console.WriteLine("Bought Car: {0}", this.got_car);
            Console.WriteLine("Current Location is: ");
            now.Display();

        }

        public string getFirstname
        {
            get { return firstName; }
        }

        public string getLastname
        {
            get { return lastName; }
        }

    }
}
