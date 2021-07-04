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

        public Person[] RemoveById(int personId)
        {
            List<Person> peopleList = new List<Person>(people);

            int removePersonIndex = 0;

            for (int i = 0; i < peopleList.Count; i++)
            {
                if (peopleList[i].PersonId == personId)
                {
                    removePersonIndex = i;
                    break;
                }
            }

            peopleList.RemoveAt(removePersonIndex);

            people = peopleList.ToArray();

            return people;
        }
    }
}
