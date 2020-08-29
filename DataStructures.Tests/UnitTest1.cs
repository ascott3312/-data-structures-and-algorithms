using System;
using Xunit;

namespace DataStructures.Tests.LinkedLists
{
    public class LinkedListTests
    {
        [Fact]
        public void LinkedList_starts_empty()
        {
            // Act
            LinkedListTests list = new LinkedListTests();

            // Assert
            Assert.Equal("NULL", list.ToString());
        }

        [Fact(Skip = "TODO for students")]
        public void Insert_adds_value_to_start()
        {
            // Arrange
            LinkedListTests list = new LinkedListTests();

            // Act
            list.Equals(1);

            // Assert
            Assert.Equal("{ 1 } -> NULL", list.ToString());

            // Act
            list.Equals(2);

            // Assert
            Assert.Equal("{ 2 } -> { 1 } -> NULL", list.ToString());
        }
    }
}