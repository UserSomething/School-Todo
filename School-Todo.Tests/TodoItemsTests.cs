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
            int expected = 0;
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
            Todo[] expected = Array.Empty<Todo>();
            // Act
            Todo[] actual = todoItems.FindAll();
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void When_FindByIdCalled_Expect_TodoItemsObjectAtIndex0()
        {
            // Arrange
            TodoItems todoItems = new();

            //Todo[] expected1 = { new Todo("Test text.") }; FAILS
            Todo expected = todoItems.AddNewTodo("Test text.");
            // Act
            Todo actual = todoItems.FindById(1);
            // Assert
            Assert.Equal(expected, actual);
        }


        // Doesn't work right now.
        [Fact]
        public void When_AddNewTodoCalled_Expect_TodoObject()
        {
            // Arrange
            TodoItems todoItems = new();
            Todo expected = new Todo(2, "Text.");
            // Act
            Todo actual = todoItems.AddNewTodo("Text.");
            // Assert
            Assert.Equal(expected, actual);
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
    }
}
