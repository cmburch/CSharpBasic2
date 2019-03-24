using System;

namespace CSharpBasic2
{   

    public class Customer
    {
        public string Name;
        public int Id;

        public Customer() { }

        public Customer(string name)
        {
            this.Name = name;
        }
        //constructor overloading
        public Customer(int id , string name) 
        {
            this.Name = name;
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
        }
    }
}
