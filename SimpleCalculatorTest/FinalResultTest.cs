using SimpleCalculatorApp;
using System;
using Xunit;

namespace SimpleCalculatorTest
{
    public class FinalResultTest
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 3, 5)]
        [InlineData(3, 3, 6)]
        [InlineData(1, 0, 1)]
        [InlineData(0, 0, 0)]
        [InlineData(-2, -5, -7)]
        [InlineData(-9, -8, -17)]
        public void AddOperation(float first, float second, float expected)
        {
            // arrange
            // act
            float result = HelperCalculation.GetFinalResult(first, second, '+');

            // assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(2, 3, -1)]
        [InlineData(3, 3, 0)]
        [InlineData(1, 0, 1)]
        [InlineData(0, 0, 0)]
        [InlineData(-2, -5, 3)]
        [InlineData(-9, -8, -1)]
        public void SubstractOperation(float first, float second, float expected)
        {
            // arrange
            // act
            float result = HelperCalculation.GetFinalResult(first, second, '-');

            // assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(2, 3, 6)]
        [InlineData(3, 3, 9)]
        [InlineData(1, 0, 0)]
        [InlineData(0, 0, 0)]
        [InlineData(-2, -5, 10)]
        [InlineData(-9, -8, 72)]
        public void MultiplyOperation(float first, float second, float expected)
        {
            // arrange
            // act
            float result = HelperCalculation.GetFinalResult(first, second, '*');

            // assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(1, 2, 0.5)]
        [InlineData(5, 1, 5)]
        [InlineData(3, 3, 1)]
        [InlineData(15, 5, 3)]
        [InlineData(6, 2, 3)]
        [InlineData(-2, -5, 0.4)]
        [InlineData(-9, -8, 1.125)]
        public void DevideOperation(float first, float second, float expected)
        {
            // arrange
            // act
            float result = HelperCalculation.GetFinalResult(first, second, '/');

            // assert
            Assert.Equal(expected, result);
        }
    }
}