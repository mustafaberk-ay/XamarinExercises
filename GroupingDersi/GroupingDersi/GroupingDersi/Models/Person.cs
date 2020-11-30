using System;
using System.Collections.Generic;
using System.Text;

namespace GroupingDersi.Models
{
    public class Person
    {
        public Person(string firstName, string lastName, string description)
        {
            FirstName = firstName;
            LastName = lastName;
            Description = description;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return FirstName + " " + LastName; } }
        public string Description { get; set; }
    }
}
