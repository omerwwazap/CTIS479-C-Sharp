using System;
using System.Collections.Generic;
using System.Text;

//1.Create at least 3 classes Buyer,Salesman,RetailSalesPerson,Re-helper
namespace LeventDurdali_HomeWork1
{
    public class Buyer
    {
        private string firstName { get; set; }
        private string lastName { get; set; }
        private string car_name { get; set; }

        // 3.There has to be at least one has-a relation between the classes.
        public Address address; //Buyer HAS-A Address  

        public Location now;
        public bool got_car;

        public void GetFullname()
        {
            Console.WriteLine("Hi! Mi name is {0} {1}, and I want a car", this.firstName, this.lastName);
        }

        public string Fullname
        {
            get
            {
                return string.Format("{0} {1}", this.firstName, this.lastName);
            }
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
        public Buyer(string firstName, string lastName, Address address, Location now, bool got_car, string car_name)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.now = now;
            this.got_car = got_car;
            this.car_name = car_name;
        }

        public void Display()
        {
            Console.WriteLine("FirstName: " + this.firstName + " LastName: " + this.lastName + "'s addres is this: " + this.address.addressLine + ", " + this.address.city + ", " + this.address.state + ".");
            if (this.got_car == false)
            {
                Console.WriteLine("The brand you are lookking at is: {0}", this.car_name);
                Console.WriteLine("Current Location is: ");
                now.Display();
            }
            else
            {
                Console.WriteLine("The Car you bought is: {0}", this.car_name);
                Console.WriteLine("Your Current Location is: ");
                now.Display();
            }

        }

    }
}
