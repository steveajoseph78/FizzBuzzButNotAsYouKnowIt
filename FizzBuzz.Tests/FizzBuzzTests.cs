using FizzBuzzEngine;
using System.Runtime.CompilerServices;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTests
    {
       
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(4)]
        public void ANumberNotDivisibleBy3or5_ReturnsTheNumberAsString(int number)
        {
            //Arrange
            string expectedResult = number.ToString();
            FizzBuzzEngine.FizzBuzzEngine fizzBuzzEngine = new FizzBuzzEngine.FizzBuzzEngine();

            //Act
            string result = fizzBuzzEngine.Calculate(number);

            //Assert
            Assert.Equal(result, expectedResult);
        }


        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        public void ANumberDivisibleBy3_ReturnsFizz(int number)
        {
            //Arrange
            string expectedResult = ConstantsFizzBuzz.Fizz;
            FizzBuzzEngine.FizzBuzzEngine fizzBuzzEngine = new FizzBuzzEngine.FizzBuzzEngine();

            //Act
            string result = fizzBuzzEngine.Calculate(number);

            //Assert
            Assert.Equal(result, expectedResult);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        public void ANumberDivisibleBy5_ReturnsBuzz(int number)
        {
            //Arrange
            string expectedResult = ConstantsFizzBuzz.Buzz;
            FizzBuzzEngine.FizzBuzzEngine fizzBuzzEngine = new FizzBuzzEngine.FizzBuzzEngine();

            //Act
            string result = fizzBuzzEngine.Calculate(number);

            //Assert
            Assert.Equal(result, expectedResult);
        }


        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(45)]
        public void ANumberDivisibleBy5And3_ReturnsFizzbuzz(int number)
        {
            //Arrange
            string expectedResult = ConstantsFizzBuzz.Fizzbuzz;
            FizzBuzzEngine.FizzBuzzEngine fizzBuzzEngine = new FizzBuzzEngine.FizzBuzzEngine();

            //Act
            string result = fizzBuzzEngine.Calculate(number);

            //Assert
            Assert.Equal(result, expectedResult);
        }

    }
}

