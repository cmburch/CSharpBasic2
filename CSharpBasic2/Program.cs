﻿using System;
using System.Collections.Generic;

namespace CSharpBasic2
{   
    public class Order
    {

    }
    public class Customer
    {
        public string Name;
        public int Id;
        public List<Order> Orders;

        public Customer()
        {
            Orders = new List<Order>();
        }

        public Customer(string name):this()//this calls the constructer without parameters
        {
            this.Name = name;
        }
        //constructor overloading
        public Customer(int id , string name):this(name)
        {
            //this.Name = name; // this line is no longer need because the constructor is called

            this.Id = id;
        }
    }

    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0} I am {1} ", to, Name);
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;

            return person;
        }
    }

    class MainClass
    {   
        //Declaring static members
        public static int PeopleCount = 0;

       
        public static void Main(string[] args)
        {
            var person = new Person();
            person.Name = "John";
            person.Introduce("Max");

            var person2 = Person.Parse("Henry");
            Console.WriteLine(person2);

            var customer = new Customer();
            //create orders
            var order = new Order();
            customer.Orders

        }
    }
}
