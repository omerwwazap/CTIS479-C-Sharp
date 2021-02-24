﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CTIS479_Homework_1
{
    public abstract class Salesman
    {
        private string firstName;
        private string lastName;
        private int age;
        private int[] sold;


        public string Fullname{
            get{
                return string.Format("{0} {1}", this.firstName, this.lastName);
            }
        }
        public string getAge{
            get{
                return string.Format("{0}",this.age);
            }
        }

        public Salesman(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Salesman(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }


        public void Sell()
        {
            this.Talk();
            this.Tell_about_car();
            this.Close();
        }

        protected abstract void Talk();
        protected abstract void Tell_about_car();
        protected abstract void Close();
    }
}