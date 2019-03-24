using System;
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

            //OBJECT INTIALIZERS
            //use this syntax when there are no constructors on your classes
            var person1 = new Person
            {
                Name = "Mosh"
            };


            var person2 = Person.Parse("Henry");
            Console.WriteLine(person2);

            var customer = new Customer();
            //create orders
            var order = new Order();
            //customer.Orders


        

            try
            {
                //create a point class

                var point1 = new Point(10, 12);
                point1.Move(null);

                point1.Move(100, 10);
            }
            catch (Exception ex)
            {
                Console.WriteLine("unexpected error has occured");
            }

        }
    }

    public class Point
    {
        public int x;
        public int y;

        public Point(int x,int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Move(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        //pass in a Point object
        public void Move(Point newLocation)
        {
            if (newLocation == null)
            {
                throw new ArgumentNullException(nameof(newLocation));
            }
            Move(newLocation.x, newLocation.y);
        }
    }

    public class Calculator
    {
        public int Add(params int[] numbers)
        {
            var sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
        }
    }
}
