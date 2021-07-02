using System;
using School_Todo.Model;

namespace School_Todo.Data
{
    public class TodoItems
    {
        private static Todo[] todoItems = Array.Empty<Todo>();

        public int Size()
        {
            return todoItems.Length;
        }

        public Todo[] FindAll()
        {
            return todoItems;
        }

        public Todo FindById(int todoId)
        {
            return todoItems[todoId - 1];
        }

        public Todo AddNewTodo(string description)
        {
            int todoId = TodoSequencer.NextTodoId();
            Todo todo = new(todoId, description);

            Array.Resize(ref todoItems, todoItems.Length + 1);
            todoItems[todoItems.Length - 1] = todo;

            return todo;
        }

        public void Clear()
        {
            todoItems = Array.Empty<Todo>();
        }
    }
}
