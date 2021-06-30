using System;
using Xunit;
using School_Todo.Model;

namespace School_Todo.Tests
{
    public class TodoTests
    {
        [Fact]
        public void When_ExpectedAndConstructorIDSame_Expect_True()
        {
            int expected = 1;

            Todo todo = new (1, "");
            int actual = todo.TodoId;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void When_ExpectedAndConstructorIDNotSame_Expect_False()
        {
            int expected = 0;

            Todo todo = new(1, "");
            int actual = todo.TodoId;

            Assert.NotEqual(expected, actual);
        }

        [Fact]
        public void When_ExpectedAndConstructorDescriptionSame_Expect_True()
        {
            string expected = "Test";

            Todo todo = new(0, "Test");
            string actual = todo.Description;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void When_ExpectedAndConstructorDescriptionNotSame_Expect_False()
        {
            string expected = "TestWrong";

            Todo todo = new(0, "Test");
            string actual = todo.Description;

            Assert.NotEqual(expected, actual);
        }
    }
}
