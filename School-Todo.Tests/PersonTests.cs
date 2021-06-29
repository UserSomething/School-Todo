using System;
using Xunit;
using School_Todo;

namespace Todo.Tests
{
    public class PersonTests
    {
        [Fact]
        public void Given_FirstAndLastNamesAssigned_When_FirstAndLastNamesAreSet_Then_ReturnFirstNameAndLastNameString()
        {
            string expected = "Bob Jones";

            Person person = new(1, "Bob", "Jones");
            string actual = $"{person.FirstName} {person.LastName}";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Given_FirstNameIsAssigned_When_FirstNameIsNullOrEmpty_Then_ReturnNoFirstNameString()
        {
            string expected = "NoFirstName";

            Person person = new (1, "", "Jones");
            string actual = person.FirstName;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Given_LastNameIsAssigned_When_LastNameIsNullOrEmpty_Then_ReturnNoLastNameString()
        {
            string expected = "NoLastName";

            Person person = new(1, "Bob", "");
            string actual = person.LastName;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Given_FirstAndLastNamesAssigned_When_FirstAndLastNamesAreNullOrEmpty_Then_ReturnNoFirstNameAndNoLastNameString()
        {
            string expected = "NoFirstName NoLastName";

            Person person = new(1, "", "");
            string actual = $"{person.FirstName} {person.LastName}";

            Assert.Equal(expected, actual);
        }
    }
}
