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
            this.todoId = todoId;
            Description = description;
        }

        public int TodoId { get => todoId; }
        public string Description 
        {
            get => description;
            set => description = value;
        }
    }
}
