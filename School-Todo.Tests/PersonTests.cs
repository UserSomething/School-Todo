using System;
using Xunit;
using School_Todo.Model;

namespace School_Todo.Tests
{
    public class PersonTests
    {
        [Fact]
        public void When_FirstAndLastNamesAreSet_Expect_ReturnFirstNameAndLastNameString()
        {
            string expected = "Bob Jones";

            Person person = new(1, "Bob", "Jones");
            string actual = $"{person.FirstName} {person.LastName}";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void When_FirstNameIsNullOrEmpty_Expect_ReturnNoFirstNameString()
        {
            string expected = "NoFirstName";

            Person person = new (1, "", "Jones");
            string actual = person.FirstName;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void When_LastNameIsNullOrEmpty_Expect_ReturnNoLastNameString()
        {
            string expected = "NoLastName";

            Person person = new(1, "Bob", "");
            string actual = person.LastName;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void When_FirstAndLastNamesAreNullOrEmpty_Expect_ReturnNoFirstNameAndNoLastNameString()
        {
            string expected = "NoFirstName NoLastName";

            Person person = new(1, "", "");
            string actual = $"{person.FirstName} {person.LastName}";

            Assert.Equal(expected, actual);
        }
    }
}
