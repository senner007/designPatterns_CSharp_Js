using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {

            IPerson h = new Hacker("Neo");

            h = new HackingSkills(h);
            h = new FlyingSkills(h);
            Console.WriteLine(h);


            IPerson s = new Student("John");

            s = new HackingSkills(s);
            s = new FlyingSkills(s);
            Console.WriteLine(s);
        }
    }
    public interface IPerson
    {
        string Description { get; set; }
        string Name { get; set; }
    }
    public abstract class Person : IPerson
    {
        public string Description { get; set; }
        public string Name { get; set; }
        public Person(string name, string description)
        {
            Name = name;
            Description = "is a " + description;
        }
    }

    public class Student : Person
    {
        public Student(string name, string description = "Student") : base(name, description)
        {
        }
    }

    public class Employee : Person
    {
        public Employee(string name, string description = "Employee") : base(name, description)
        {
        }
    }
    public class Hacker : Person
    {
        public Hacker(string name, string description = "Hacker") : base(name, description)
        {
        }
    }
}
