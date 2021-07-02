using System;

namespace School_Todo.Model
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

        public int PersonId { get => personId; }

        public string FirstName
        {
            get => firstName;
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
            get => lastName;
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
