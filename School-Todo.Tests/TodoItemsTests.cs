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
            Todo[] expected = { new Todo(1, "Test text 4.") };
            // Act
            Todo[] actual = todoItems.FindAll();
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void When_FindByIdCalled_Expect_TodoItemsObject()
        {
            // Arrange
            TodoItems todoItems = new();

            Todo expected = todoItems.AddNewTodo("Test text.");
            // Act
            Todo actual = todoItems.FindById(5);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void When_FindByDoneStatusCalled_Expect_TodoItemsArray()
        {
            // Arrange
            TodoItems todoItems = new();

            Todo exp1 = new(1, "Test");
            Todo exp2 = new(2, "Test 2");

            exp1.Done = true;
            exp2.Done = false;

            Todo[] expected = { exp1 };

            // Act
            Todo[] actual = todoItems.FindByDoneStatus(true);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void When_FindByAssigneeIdParameter_Expect_TodoItemsArray()
        {
            // Arrange
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
            TodoItems todoItems = new();

            Todo exp1 = todoItems.AddNewTodo("Test text 6.");
            Todo exp2 = todoItems.AddNewTodo("Test text 7.");

            exp1.Assignee = new Person(10, "Troy", "Johnson");
            exp2.Assignee = new Person(11, "Steve", "Steveson");

            Todo[] expected = { exp1 };

            // Act
            Todo[] actual = todoItems.FindByAssingnee(new Person(1, "Peter", "Abc"));

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void When_FindUnassignedTodoItemsCalled_Expect_UnassignedTodoItemsArray()
        {
            // Arrange
            TodoItems todoItems = new();

            Todo exp1 = todoItems.AddNewTodo("Test text 4.");

            Todo[] expected = { exp1 };

            // Act
            Todo[] actual = todoItems.FindUnassignedTodoItems();

            // Assert
            Assert.Equal(expected, actual);
        }

        // Doesn't work right now.
        [Fact]
        public void When_AddNewTodoCalled_Expect_TodoObject()
        {
            // Arrange
            TodoItems todoItems = new();
            Todo expected = new Todo(9, "Text.");
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

            Todo[] expected = { new Todo(9, "A text 2.") };
            // Act
            todoItems.RemoveById(5);
            // Assert
            //Assert.Equal(expected, actual);
        }
    }
}
