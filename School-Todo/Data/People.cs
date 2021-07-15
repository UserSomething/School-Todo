using System;
using System.Collections.Generic;
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
            Person foundPerson = null;

            for (int i = 0; i < people.Length; i++)
            {
                if (people[i].PersonId == personId)
                {
                    foundPerson = people[i];
                    break;
                }
            }

            return foundPerson;
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

        public void RemoveById(int personId)
        {
            for (int i = personId - 1; i < people.Length - 1; i++)
            {
                people[i] = people[i + 1];
            }

            Person[] tempArray = new Person[people.Length - 1];
            Array.Copy(people, tempArray, tempArray.Length);

            people = tempArray;
        }
    }
}
