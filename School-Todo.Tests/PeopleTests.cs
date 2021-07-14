using School_Todo.Data;
using School_Todo.Model;
using System;
using Xunit;

namespace School_Todo.Tests
{
    public class PeopleTests
    {
        [Fact]
        public void When_SizeCalled_Expect_PeopleArrayLength()
        {
            // Arrange
            People people = new();
            int expected = 0;
            // Act
            int actual = people.Size();
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void When_FindAllCalled_Expect_PeopleArray()
        {
            // Arrange
            People people = new();
            string expectedString = "Abc, John";
            // Act
            Person[] actual = people.FindAll();
            string actualString = $"{actual[0].FirstName}, {actual[1].FirstName}";
            // Assert
            Assert.Equal(expectedString, actualString);
        }

        [Fact]
        public void When_FindByIdCalled_Expect_PersonObject()
        {
            // Arrange
            People people = new();

            Person expected = people.AddNewPerson("John", "Smith");
            // Act
            Person actual = people.FindById(11);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void When_AddNewPersonCalled_Expect_PersonObject()
        {
            // Arrange
            People people = new();
            Person expected = new Person(5, "John", "Smith");
            string expectedString = $"{expected.PersonId} {expected.FirstName} {expected.LastName}";
            // Act
            Person actual = people.AddNewPerson("John", "Smith");
            string actualString = $"{actual.PersonId} {actual.FirstName} {actual.LastName}";
            // Assert
            Assert.Equal(expectedString, actualString);
        }

        [Fact]
        public void When_ClearCalled_Expect_PeopleArrayEmpty()
        {
            // Arrange
            People people = new ();
            people.AddNewPerson("John", "Smith");
            Person[] expected = Array.Empty<Person>();
            // Act
            people.Clear();
            // Assert
            Assert.Empty(expected);
        }

        [Fact]
        public void When_RemoveAtIdCalled_Expect_PersonElementRemoved()
        {
            // Arrange
            People people = new ();
            people.AddNewPerson("Abc", "123");
            people.AddNewPerson("Troy", "Troyson");

            string expected = "7, Abc, 123";
            // Act
            people.RemoveById(8);

            Person[] arrayPerson = people.FindAll();
            string actual = $"{arrayPerson[0].PersonId}, {arrayPerson[0].FirstName}, {arrayPerson[0].LastName}";
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
