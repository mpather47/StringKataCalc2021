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
        public void ReturnsNumberGivenStringOneNumber(string numbers, int expectedResult)
        {
            var result = _calculator.Add(numbers);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("1,2", 3)]
        [InlineData("2,3", 5)]
        public void ReturnsSumGivenStringTwoCommaSeperatedNumbers(string numbers, int expectedResult)
        {
            var result = _calculator.Add(numbers);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("1,2,3", 6)]
        [InlineData("2,3,4", 9)]
        public void ReturnsSumGivenStringThreeCommaSeperatedNumbers(string numbers, int expectedResult)
        {
            var result = _calculator.Add(numbers);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("1\n2,3", 6)]
        [InlineData("1\n2\n3", 6)]
        [InlineData("1,2\n3", 6)]
        public void ReturnsSumGivenStringThreeCommaOrNewlineSeperatedNumbers(string numbers, int expectedResult)
        {
            var result = _calculator.Add(numbers);

            Assert.Equal(expectedResult, result);
        }


        [Theory]
        [InlineData("//;\n1;2;3", 6)]
        public void ReturnsSumGivenStringCustomDelimeter(string numbers, int expectedResult)
        {
            var result = _calculator.Add(numbers);

            Assert.Equal(expectedResult, result);
        }
    }
}
