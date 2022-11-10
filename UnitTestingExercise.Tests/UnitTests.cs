using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1,2,3,6)]
        [InlineData(2,2,3,7)]
        [InlineData(8,0,1,9)]
        [InlineData(-5,0,5,0)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            UnitTestMethods unitTestMethods = new UnitTestMethods();

            //Act
            int result = unitTestMethods.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData( 10, 0, 10)]
        [InlineData( -2, 4, -6)]
        [InlineData( 2, 4, -2)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            UnitTestMethods unitTestMethods = new UnitTestMethods();

            //Act
            int result = unitTestMethods.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData( 3, 3, 9)]
        [InlineData( 0, 3, 0)]
        [InlineData( 5, 5, 25)]
        [InlineData( -3, 3, -9)]
        [InlineData(-11, -11, 121)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            UnitTestMethods unitTestMethods = new UnitTestMethods();

            //Act
            int result = unitTestMethods.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(5, 1, 5)]
        [InlineData(1, 5, 0)]
        [InlineData(0, -12, 0)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            UnitTestMethods unitTestMethods = new UnitTestMethods();

            //Act
            int result = unitTestMethods.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Baka()
        {
            //Arrange
            UnitTestMethods unitTestMethods = new UnitTestMethods();

            //Act
            int result = unitTestMethods.Baka();

            //Assert
            Assert.Equal(13, result);
        }

        [Fact]
        public void BakaBaka()
        {
            //Arrange
            UnitTestMethods unitTestMethods = new UnitTestMethods();

            //Act
            int result = unitTestMethods.BakaBaka();

            //Assert
            Assert.Equal(26, result);
        }
    }
}
