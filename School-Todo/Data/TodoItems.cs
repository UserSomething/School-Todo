using System;
using System.Collections.Generic;
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
            Todo foundTodo = null;

            for (int i = 0; i < todoItems.Length; i++)
            {
                if (todoItems[i].TodoId == todoId)
                {
                    foundTodo = todoItems[i];
                    break;
                }
            }

            return foundTodo;
        }

        public Todo[] FindByDoneStatus(bool doneStatus)
        {
            Todo[] resultArray = Array.Empty<Todo>();

            for (int i = 0; i < todoItems.Length; i++)
            {
                if (todoItems[i].Done == doneStatus)
                {
                    Array.Resize(ref resultArray, resultArray.Length + 1);
                    resultArray[i] = todoItems[i];
                }
            }

            return resultArray;
        }

        public Todo[] FindByAssingnee(int personId)
        {
            Todo[] resultArray = Array.Empty<Todo>();

            for (int i = 0; i < todoItems.Length; i++)
            {
                if (todoItems[i].TodoId == personId)
                {
                    Array.Resize(ref resultArray, resultArray.Length + 1);
                    resultArray[i] = todoItems[i];
                }
            }

            return resultArray;
        }

        public Todo[] FindByAssingnee(Person assignee)
        {
            Todo[] resultArray = Array.Empty<Todo>();

            for (int i = 0; i < todoItems.Length; i++)
            {
                if (todoItems[i].Assignee == assignee)
                {
                    Array.Resize(ref resultArray, resultArray.Length + 1);
                    resultArray[i] = todoItems[i];
                }
            }

            return resultArray;
        }

        public Todo[] FindUnassignedTodoItems()
        {
            Todo[] resultArray = Array.Empty<Todo>();

            for (int i = 0; i < todoItems.Length; i++)
            {
                if (todoItems[i].Assignee == null)
                {
                    Array.Resize(ref resultArray, resultArray.Length + 1);
                    resultArray[i] = todoItems[i];
                }
            }

            return resultArray;
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

        public void RemoveById(int todoId)
        {
            List<Todo> todoItemsList = new List<Todo>(todoItems);

            int removeTodoIndex = 0;

            for (int i = 0; i < todoItemsList.Count; i++)
            {
                if (todoItemsList[i].TodoId == todoId)
                {
                    removeTodoIndex = i;
                    break;
                }
            }

            todoItemsList.RemoveAt(removeTodoIndex);

            todoItems = todoItemsList.ToArray();

            //return todoItems;
        }
    }
}
