using System;
using Xunit;

namespace StringKataCalc2021
{
    public class StringCalculator_Add
    {
        StringCalculator _calculator = new StringCalculator();

        [Fact]
        public void Returns0GivenEmptyString()
        {
            var result = _calculator.Add("");

            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData("1",1)]
        [InlineData("2", 2)]
        public void Returns1GivenString1(string numbers, int expectedResult)
        {
            var result = _calculator.Add(numbers);

            Assert.Equal(expectedResult, result);
        }

    }
}
