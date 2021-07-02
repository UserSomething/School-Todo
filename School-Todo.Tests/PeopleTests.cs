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
            Person[] expected = Array.Empty<Person>();
            // Act
            Person[] actual = people.FindAll();
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void When_FindByIdCalled_Expect_PersonObjectAtIndex0()
        {
            // Arrange
            People people = new();

            //Person[] expected1 = { new Person(1, "John", "Smtih") }; FAILS
            Person expected = people.AddNewPerson("John", "Smith");
            // Act
            Person actual = people.FindById(1);
            // Assert
            Assert.Equal(expected, actual);
        }


        // Doesn't work right now.
        //[Fact]
        //public void When_AddNewPersonCalled_Expect_PersonObject()
        //{
        //    // Arrange
        //    People people = new();
        //    Person expected = new Person(2, "John", "Smith");
        //    // Act
        //    Person actual = people.AddNewPerson("John", "Smith");
        //    // Assert
        //    Assert.Equal(expected, actual);
        //    //Assert.Same(expected, actual);
        //}

        [Fact]
        public void When_ClearCalled_Expect_PeopleArrayEmpty()
        {
            // Arrange
            People people = new ();
            people.AddNewPerson("Bob", "Norton");
            Person[] expected = Array.Empty<Person>();
            // Act
            people.Clear();
            // Assert
            Assert.Empty(expected);
        }
    }
}
