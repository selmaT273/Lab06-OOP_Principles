using System;
using Lab06_OOP_Principles;
using Xunit;

namespace Lab06_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Act
            Poodle poodle = new Poodle();

            // Assert
            Assert.Equal("black", poodle.Color);



        }
    }
}
