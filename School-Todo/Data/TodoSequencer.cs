using System;

namespace School_Todo.Data
{
    public static class TodoSequencer
    {
        private static int todoId = 0;

        public static int TodoId { get { return todoId; } }

        public static int NextTodoId()
        {
            return ++todoId;
        }

        public static void Reset()
        {
            todoId = 0;
        }
    }
}
