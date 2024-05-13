using ContarPalabrasyCalculos;

namespace ContarPalabrasyCalculosTests
{
    public class StringOperationsTests
    {
        public StringOperations _stringOperations;

        public StringOperationsTests()
        {
            _stringOperations = new StringOperations();
        }

        // Prueba para el método CountCharacters
        [Theory]
        [InlineData("Hola", 4)]
        [InlineData("Programación", 12)]
        [InlineData("", 0)]
        [InlineData(null, 0)]
        public void CountCharacters_ShouldReturnCorrectCharacterCount(string input, int expectedCount)
        {
            // Act
            int actualCount = _stringOperations.CountCharacters(input);

            // Assert
            Assert.Equal(expectedCount, actualCount);
        }
    }

    public class MathOperationsTests
    {
        private MathOperations _mathOperations;

        public MathOperationsTests()
        {
            _mathOperations = new MathOperations();
        }

        // Prueba para el método Add
        [Theory]
        [InlineData(2, 3, 5)]
        [InlineData(10, 20, 30)]
        [InlineData(-5, 7, 2)]
        public void Add_ShouldReturnCorrectSum(int a, int b, int expectedSum)
        {
            // Act
            int actualSum = _mathOperations.Add(a, b);

            // Assert
            Assert.Equal(expectedSum, actualSum);
        }
    }
}