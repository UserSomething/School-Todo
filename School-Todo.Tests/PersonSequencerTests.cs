using System;
using Xunit;
using School_Todo.Data;

namespace TodoP.Tests
{
    public class PersonSequencerTests
    {
        [Fact]
        public void When_NextPersonIdMethodCalled_Expect_PersonIdEqualsOne()
        {
            int expected = 1;
            int actual = PersonSeqencer.NextPersonId();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void When_ResetMethodCalled_Expect_PersonIdEqualsZero()
        {
            int expected = 0;
            int idIsOne = PersonSeqencer.NextPersonId();

            PersonSeqencer.Reset();
            int actual = PersonSeqencer.PersonId;

            Assert.Equal(expected, actual);
        }
    }
}
