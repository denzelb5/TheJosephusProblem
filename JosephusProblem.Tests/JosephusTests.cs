using System;
using Xunit;

namespace TheJosephusProblem.Tests
{
    public class JosephusTests
    {
        [Fact]
        public void Interval3()
        {
            // Arrange
            var numberOfPeeps = 10;
            var killingInterval = 3;
            var expectedResult = 4;
            var checkResult = new JosephusCalculator();

            // Act
            var actualResult = checkResult.LastManStanding(numberOfPeeps, killingInterval);


            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void Interval2()
        {
            // Arrange
            var numberOfPeeps = 14;
            var killingInterval = 2;
            var expectedResult = 13;
            var checkResult = new JosephusCalculator();

            // Act
            var actualResult = checkResult.LastManStanding(numberOfPeeps, killingInterval);


            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void Interval9()
        {
            // Arrange
            var numberOfPeeps = 42;
            var killingInterval = 9;
            var expectedResult = 21;
            var checkResult = new JosephusCalculator();

            // Act
            var actualResult = checkResult.LastManStanding(numberOfPeeps, killingInterval);


            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void Interval7()
        {
            // Arrange
            var numberOfPeeps = 512;
            var killingInterval = 7;
            var expectedResult = 26;
            var checkResult = new JosephusCalculator();

            // Act
            var actualResult = checkResult.LastManStanding(numberOfPeeps, killingInterval);


            // Assert
            Assert.Equal(expectedResult, actualResult);
        }


    }
}
