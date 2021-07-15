using System;
using System.Collections.Generic;
using School_Todo.Model;

namespace School_Todo.Data
{
    public class TodoItems
    {
        private static Todo[] todoItems = Array.Empty<Todo>();

        private int nextArrayIndex = 0;
        private int nextArrayIndex2 = 0;
        private int nextArrayIndex3 = 0;
        private int nextArrayIndex4 = 0;

        private Todo[] resultArrayPersonId = Array.Empty<Todo>();
        private Todo[] resultArrayPersonObject = Array.Empty<Todo>();
        private Todo[] resultArrayBool = Array.Empty<Todo>();
        private Todo[] resultArrayUniassigned = Array.Empty<Todo>();

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
            for (int i = 0; i < todoItems.Length; i++)
            {
                if (todoItems[i].Done.Equals(doneStatus))
                {
                    Array.Resize(ref resultArrayBool, resultArrayBool.Length + 1);
                    resultArrayBool[nextArrayIndex3] = todoItems[i];
                    nextArrayIndex3++;
                }
            }

            return resultArrayBool;
        }
        
        public Todo[] FindByAssingnee(int personId)
        {
            People people = new();

            for (int i = 0; i < people.Size(); i++)
            {
                if (people.FindAll()[i].PersonId == personId)
                {
                    Array.Resize(ref resultArrayPersonId, resultArrayPersonId.Length + 1);

                    resultArrayPersonId[nextArrayIndex] = todoItems[i];
                    nextArrayIndex++;
                }
            }

            return resultArrayPersonId;
        }

        public Todo[] FindByAssingnee(Person assignee)
        {
            People people = new();

            for (int i = 0; i < people.Size(); i++)
            {
                if (assignee.Equals(people.FindAll()[i]))
                {
                    Array.Resize(ref resultArrayPersonObject, resultArrayPersonObject.Length + 1);

                    this.resultArrayPersonObject[nextArrayIndex2] = todoItems[i];
                    nextArrayIndex2++;
                }
            }

            return resultArrayPersonObject;
        }

        public Todo[] FindUnassignedTodoItems()
        {
            for (int i = 0; i < todoItems.Length; i++)
            {
                if (todoItems[i].Assignee == null)
                {
                    Array.Resize(ref resultArrayUniassigned, resultArrayUniassigned.Length + 1);
                    resultArrayUniassigned[i] = todoItems[i];
                }
            }

            return resultArrayUniassigned;


            //for (int i = 0; i < todoItems.Length; i++)
            //{
            //    if (todoItems[i].Done.Equals(doneStatus))
            //    {
            //        Array.Resize(ref resultArrayBool, resultArrayBool.Length + 1);
            //        resultArrayBool[nextArrayIndex3] = todoItems[i];
            //        nextArrayIndex3++;
            //    }
            //}

            //return resultArrayBool;
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
            for (int i = todoId - 1; i < todoItems.Length - 1; i++)
            {
                todoItems[i] = todoItems[i + 1];
            }

            Todo[] tempArray = new Todo[todoItems.Length - 1];
            Array.Copy(todoItems, tempArray, tempArray.Length);

            todoItems = tempArray;
        }
    }
}
