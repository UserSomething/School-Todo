using System;

namespace School_Todo
{
    public class Person
    {
        readonly int personId;
        string firstName;
        string lastName;

        public Person(int personId, string firstName, string lastName)
        {
            this.personId = personId;
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    firstName = "NoFirstName";
                }
                else
                {
                    firstName = value;
                }
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    lastName = "NoLastName";
                }
                else
                {
                    lastName = value;
                }
            }
        }
    }
}

