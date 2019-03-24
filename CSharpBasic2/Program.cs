using System;

namespace CSharpBasic2
{   
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0} I am {1} ", to, Name);
        }

        public Person Parse(string str)
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
        }
    }
}
