using System;
using System.Collections.Generic;
using System.Text;

//3.There has to be at least one has-a relation between the classes.
//7.Last sub class in the in the inheritance must be the final class and cannot be extended.
namespace LeventDurdali_HomeWork1
{
    public sealed class Address
    {
        public string addressLine, city, state;
        public Address(string addressLine, string city, string state)
        {
            this.addressLine = addressLine;
            this.city = city;
            this.state = state;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }


    }
}
