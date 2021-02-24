using System;
using System.Collections.Generic;
using System.Text;

namespace CTIS479_Homework_1
{
    public class Buyer
    {
        private string firstName;
        private string lastName;
        private int[] bought;

        public void GetFullname()
        {
            Console.WriteLine("Hi! Mi name is {0} {1}, and I want a car", this.firstName, this.lastName);
        }
        public Buyer(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public Buyer(string firstName, string lastName, int[] bought) : this(firstName, lastName)
        {
            this.bought = bought;
        }

    }
}
