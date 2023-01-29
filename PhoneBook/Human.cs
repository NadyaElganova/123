using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Human : IComparable<Human>
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public long PhoneNumber { get; private set; }
        public Human(string firstName, string lastName, long phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
        }
        public string Show()
        {
            return $"{FirstName} {LastName} {PhoneNumber}";
        }
        public static bool LastNameSort { get; set; }
        public int CompareTo(Human other)
        {
            if (LastNameSort == false)
            {
                return FirstName.CompareTo(other.FirstName);
            }
            else 
            {
                return LastName.CompareTo(other.LastName);
            }
        }
    }
}
