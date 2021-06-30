using System;
using Xunit;
using School_Todo.Data;

namespace School_Todo.Tests
{
    public class TodoSequencerTests
    {
        [Fact]
        public void When_NextTodoIdMethodCalled_Expect_TodoIdEqualsOne()
        {
            int expected = 1;
            int actual = TodoSequencer.NextTodoId();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void When_ResetMethodCalled_Expect_TestIdEqualsZero()
        {
            int expected = 0;
            int idIsOne = TodoSequencer.NextTodoId();

            TodoSequencer.Reset();
            int actual = TodoSequencer.TodoId;

            Assert.Equal(expected, actual);
        }
    }
}

