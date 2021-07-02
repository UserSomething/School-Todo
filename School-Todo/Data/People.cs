using System;
using School_Todo.Model;

namespace School_Todo.Data
{
    public class People
    {
        private static Person[] people = Array.Empty<Person>();

        public int Size()
        {
            return people.Length;
        }

        public Person[] FindAll()
        {
            return people;
        }

        public Person FindById(int personId)
        {
            return people[personId - 1];
        }

        public Person AddNewPerson(string firstName, string lastName)
        {
            int personId = PersonSeqencer.NextPersonId();
            Person person = new (personId, firstName, lastName);

            Array.Resize(ref people, people.Length + 1);
            people[people.Length - 1] = person;

            return person;
        }

        public void Clear()
        {
            people = Array.Empty<Person>();
        }
    }
}
