using FizzBuzz.Contracts;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTests
    {
        private readonly IFizzBuzzService _sut;

        public FizzBuzzTests()
        {
            _sut = new FizzBuzzService();
        }

        [Fact]
        public void ShowResult_ReturnsOneFizz()
        {
            //Arrange
            var inputs = new int[] { 1, 2, 3 };

            var expectedResult = new string[] { "1", "2", "Fizz" };

            //Act
            var result = _sut.ShowResult(inputs);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void ShowResult_ReturnsOneBuzz()
        {
            //Arrange
            var inputs = new int[] { 5, 6, 7 };

            var expectedResult = new string[] { "Buzz", "Fizz", "7" };

            //Act
            var result = _sut.ShowResult(inputs);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void ShowResult_ReturnsFizzBuzz()
        {
            //Arrange
            var inputs = Enumerable.Range(1, 16);

            var expectedResult = new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz", "16" };

            //Act
            var result = _sut.ShowResult(inputs);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void ShowResult_ReturnsArgumentNullException()
        {
            // Arrange
            var inputs = new List<int>();

            var expectedResult = new string[] { "1", "2", "Fizz" };

            // Act
            var exception = () => _sut.ShowResult(inputs);

            // Assert
            Assert.Throws<ArgumentNullException>(exception);
        }

        [Fact]
        public void ShowResult_ReturnsArgumentOutOfRangeException()
        {
            // Arrange
            var inputs = Enumerable.Range(-1, 16);

            var expectedResult = new string[] { "1", "2", "Fizz" };

            // Act
            var exception = () => _sut.ShowResult(inputs);

            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(exception);
        }
    }
}
