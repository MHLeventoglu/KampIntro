using System;
using System.Numerics;


namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.PersonName = "Muaz";
            person1.PersonId = "12345";
            person1.PersonAge = 18;

            Person person2 = new Person();
            person1.PersonName = "Hamza";
            person1.PersonId = "54321";
            person1.PersonAge = 81;


            Customer customer1 = new Customer();
            customer1.PersonName = "Salih";
            Customer customer2 = new Customer();
            

            Employee employee1 = new Employee();
            Employee employee2 = new Employee();

            Person person3 = customer1;
            //Console.WriteLine(person3.PersonName);
            //Console.WriteLine("deneme........");

            PersonManager personManager = new PersonManager();
            personManager.Add(person3);
            personManager.Add(customer1);
            personManager.Add(employee2);
        }


        
    }
    class Person //Person is the base class here.
    {
        public string? PersonName { get; set; }
        public string? PersonId { get; set; }
        public int PersonAge { get; set; }
    }
                  //"Customer" and "Person" classes are kind of type of "Person" here.
    class Customer : Person
    {
        public string? CustomerIdNo { get; set; }

    }

    class Employee : Person
    {
        public string? EmployeeIdNo { get; set; }

    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.PersonName);
        }
    }
}