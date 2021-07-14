using School_Todo.Data;
using School_Todo.Model;
using System;

namespace School_Todo
{
    class Program
    {
        static void Main(string[] args)
        {


            TodoItems todoItems = new();
            todoItems.AddNewTodo("Text for Abc.");
            todoItems.AddNewTodo("Text for John.");
            todoItems.AddNewTodo("Text for Todd.");

            People people = new();
            //people.AddNewPerson("Abc", "123");
            //people.AddNewPerson("John", "Smith");
            //people.AddNewPerson("Todd", "Johnson");

            Person person1 = people.AddNewPerson("Abc", "123");
            Person person2 = people.AddNewPerson("John", "Smith");
            Person person3 = people.AddNewPerson("Todd", "Johnson");

            Todo todo1 = new(1, "Abc todo.");
            Todo todo2 = new(2, "John todo.");
            Todo todo3 = new(3, "Todd todo.");

            todo1.Assignee = person1;
            todo2.Assignee = person2;
            todo3.Assignee = person3;

            Todo[] todoArray = Array.Empty<Todo>();
            todoArray = todoItems.FindByAssingnee(todo1.Assignee);
            todoArray = todoItems.FindByAssingnee(todo3.Assignee);

            //Console.WriteLine("Hello World!");
        }
    }
}
