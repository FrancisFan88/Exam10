using System;
using System.Linq;

namespace Exam10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Adult adult1 = new Adult("Talor",  "AA");
            Child child1 = new Child("Child1", "BB");            
            Adult[] persons = new Adult[2];
            persons.Append(adult1);
            persons.Append(child1);
            foreach (person in persons)
            {
                Console.WriteLine(person.firstname, person.lastname);
            }
        }
    }
    
    public class Adult
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Adult(string firstname, string lastname)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            Console.WriteLine("First Name:{0},Last Name: {1}", this.FirstName, this.LastName);
        }
        public Adult()
        {
            Console.WriteLine("First Name:{0},Last Name:{1}", this.FirstName, this.LastName);
        }
    }
    public class Child
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Child(string firstname, string lastname)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            Console.WriteLine("First Name:{0},Last Name:{1}", this.FirstName, this.LastName);
        }
        public Child()
        {
            Console.WriteLine("First Name:{0},Last Name:{1}", this.FirstName, this.LastName);
        }
    }
}
