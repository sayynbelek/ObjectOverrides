using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOverrides
{
    class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int Age { get; set; }
        public Person(string fName, string lname, int personAge)
        {
            firstName = fName;
            lastName = lname;
            Age = personAge;
        }
        public Person() { }
       /* public override string ToString()
        {
            string myState;
            myState = string.Format("[First Name: {0}; Last Name: {1}; Age: {2}]",
                firstName, lastName, Age);      
        } */
        public override bool Equals(object obj)
        {
            return obj.ToString() == this.ToString();
        }
        public string SSN { get; set; }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public void StaticMembersOfObject()
        {
            Person p3 = new Person("Sally", "Jones", 4);
            Person p4 = new Person("Sally", "Jones", 4);
            Console.WriteLine("P3 and P4 have same state: {0}", object.Equals(p3, p4));
            Console.WriteLine("P3 and P4 are pointing to same object: {0}",
                object.ReferenceEquals(p3, p4));
        }
    }
}
