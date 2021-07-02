using System;

namespace School_Todo.Data
{
    public static class PersonSeqencer
    {
        private static int personId = 0;

        public static int PersonId 
        {
            get => personId;
            set => personId = value;
        }

        public static int NextPersonId()
        {
            return ++PersonId;
        }

        public static void Reset()
        {
            personId = 0;
        }
    }
}
