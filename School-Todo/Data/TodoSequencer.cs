using System;

namespace School_Todo.Data
{
    public static class TodoSequencer
    {
        private static int todoId = 0;

        public static int TodoId
        {
            get => todoId;
            set => todoId = value;
        }

        public static int NextTodoId()
        {
            return ++TodoId;
        }

        public static void Reset()
        {
            todoId = 0;
        }
    }
}
