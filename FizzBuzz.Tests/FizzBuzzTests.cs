using System.Runtime.CompilerServices;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTests
    {
        [Fact]
        public void ANumberNotDivisibleBy3or5_ReturnsTheNumberAsString()
        {
            //Arrange
            string expectedResult = "1";
            int number = 1;

            //Act
            string result = FizzBuzzEngine.Calculate(number);


            //Assert
            Assert.Equal(result, expectedResult);
        }
    }
}


public static class FizzBuzzEngine
{
    public static string Calculate(int number)
    {
        return "1";
    } 
}