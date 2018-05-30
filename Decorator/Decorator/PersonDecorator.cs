using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class PersonDecorator : IPerson
    {
        
        IPerson person;

        public PersonDecorator(IPerson _person)
        {
            person = _person;
            Description = person.Description;
            Name = person.Name;
        }

        public string Description { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name + ", " + Description;
        }
    }
    public class HackingSkills : PersonDecorator
    {
        public HackingSkills(IPerson _person) : base(_person)
        {
            Description = _person.Description + ", has Hacking Skills";
        }
    }
    public class FlyingSkills : PersonDecorator
    {
        public FlyingSkills(IPerson _person) : base(_person)
        {
            Description = _person.Description + ", has Flying Skills";
        }
    }
}
