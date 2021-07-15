using School_Todo.Data;
using School_Todo.Model;
using System;
using Xunit;

namespace School_Todo.Tests
{
    public class TodoItemsTests
    {
        [Fact]
        public void When_SizeCalled_Expect_TodoItemsArrayLength()
        {
            // Arrange
            TodoItems todoItems = new();
            int expected = 1;
            // Act
            int actual = todoItems.Size();
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void When_FindAllCalled_Expect_TodoItemsArray()
        {
            // Arrange
            TodoItems todoItems = new();
            todoItems.AddNewTodo("Test text 4.");
            todoItems.AddNewTodo("Test text 6.");

            Todo[] expected = { new Todo(1, "Test text 4.") };
            string expectedString = "1, Test text 4. 3, Text for Abc.";
            // Act
            Todo[] actual = todoItems.FindAll();
            string actualString = $"{actual[0].TodoId}, {actual[0].Description} {actual[1].TodoId}, {actual[1].Description}";
            // Assert
            Assert.Equal(expectedString, actualString);


        }

        [Fact]
        public void When_FindByIdCalled_Expect_TodoItemsObject()
        {
            // Arrange
            TodoItems todoItems = new();

            Todo expected = todoItems.AddNewTodo("Test text.");
            // Act
            Todo actual = todoItems.FindById(15);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void When_FindByDoneStatusCalled_Expect_TodoItemsArray()
        {
            // Arrange
            TodoItems todoItems = new();

            //Todo exp1 = new(1, "Test");
            //Todo exp2 = new(2, "Test 2");

            Todo exp1 = todoItems.AddNewTodo("Test");
            Todo exp2 = todoItems.AddNewTodo("Test 2");

            exp1.Done = true;
            exp2.Done = false;

            bool expectedBool = true;

            // Act
            Todo[] actual = todoItems.FindByDoneStatus(true);
            bool actualBool = actual[0].Done;

            // Assert
            Assert.Equal(expectedBool, actualBool);
        }

        [Fact]
        public void When_FindByAssigneeIdParameter_Expect_TodoItemsArray()
        {
            // Arrange
            People people = new();
            people.AddNewPerson("Abc", "123");
            people.AddNewPerson("John", "Smith");
            people.AddNewPerson("Todd", "Johnson");

            TodoItems todoItems = new();

            Todo exp1 = todoItems.AddNewTodo("Test text 4.");

            Todo[] expected = { exp1 };

            // Act
            Todo[] actual = todoItems.FindByAssingnee(1);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void When_FindByAssigneePersonParameter_Expect_TodoItemsArray()
        {
            // Arrange
            People people = new ();
            Person person1 = people.AddNewPerson("Abc", "123");
            Person person2 = people.AddNewPerson("John", "Smith");

            Todo todo1 = new (1, "Todo 1");
            Todo todo2 = new (2, "Todo 2");

            todo1.Assignee = person1;
            todo2.Assignee = person2;

            TodoItems todoItems = new();
            todoItems.AddNewTodo("Text for Abc.");
            todoItems.AddNewTodo("Text for John.");
            todoItems.AddNewTodo("Text for Todd.");

            Todo[] todoArray = Array.Empty<Todo>();
            string expectedString = $"1, Test text 4. 3, Text for Abc.";

            // Act
            todoArray = todoItems.FindByAssingnee(todo1.Assignee);
            todoArray = todoItems.FindByAssingnee(todo2.Assignee);

            string actualString = $"{todoArray[0].TodoId}, {todoArray[0].Description} {todoArray[1].TodoId}, {todoArray[1].Description}";


            // Assert
            Assert.Equal(expectedString, actualString);
        }

        [Fact]
        public void When_FindUnassignedTodoItemsCalled_Expect_UnassignedTodoItemsArray()
        {
            // Arrange
            TodoItems todoItems = new();

            todoItems.AddNewTodo("Test text 4.");

            // Act
            Todo[] actual = todoItems.FindUnassignedTodoItems();

            // Assert
            Assert.Null(actual[0].Assignee);
        }

        [Fact]
        public void When_AddNewTodoCalled_Expect_TodoObject()
        {
            // Arrange
            TodoItems todoItems = new();
            Todo expected = new Todo(14, "Text.");
            string expectedString = $"{expected.TodoId} {expected.Description}";
            // Act
            Todo actual = todoItems.AddNewTodo("Text.");
            string actualString = $"{actual.TodoId} {actual.Description}";
            // Assert
            Assert.Equal(expectedString, actualString);
            //Assert.Same(expected, actual);
        }

        [Fact]
        public void When_ClearCalled_Expect_TodoItemsArrayEmpty()
        {
            // Arrange
            TodoItems todoItems = new();
            todoItems.AddNewTodo("The computer works.");
            Todo[] expected = Array.Empty<Todo>();
            // Act
            todoItems.Clear();
            // Assert
            Assert.Empty(expected);
        }

        [Fact]
        public void When_RemoveAtIdCalled_Expect_TodoElementRemoved()
        {
            // Arrange
            TodoItems todoItems = new();
            todoItems.AddNewTodo("A text.");
            todoItems.AddNewTodo("A text 2.");

            string expected = "12, A text.";

            // Act
            todoItems.RemoveById(11);

            Todo[] arrayTodo = todoItems.FindAll();
            string actual = $"{arrayTodo[0].TodoId}, {arrayTodo[0].Description}";
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
