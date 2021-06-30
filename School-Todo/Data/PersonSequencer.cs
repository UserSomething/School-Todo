using System;

namespace School_Todo.Data
{
    public static class PersonSeqencer
    {
        private static int personId = 0;

        public static int PersonId { get { return personId; } }

        public static int NextPersonId()
        {
            return ++personId;
        }

        public static void Reset()
        {
            personId = 0;
        }
    }
}
