using System;

namespace School_Todo.Model
{
    public class Todo
    {
        readonly int todoId;
        string description;
        bool done;
        Person assingee;

        public Todo(int todoId, string description)
        {
            TodoId = todoId;
            Description = description;
        }

        public int TodoId { get; }
        public string Description { get; set; }
    }
}
