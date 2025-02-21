using Xunit;

namespace ProjektZaliczeniowy.Tests
{
    public class SampleTests
    {
        [Fact]
        public void TestDodawania()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Act
            int wynik = a + b;

            // Assert
            Assert.Equal(8, wynik);
        }

        [Fact]
        public void TestOdejmowania()
        {
            // Arrange
            int a = 10;
            int b = 4;

            // Act
            int wynik = a - b;

            // Assert
            Assert.Equal(6, wynik);
        }

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(3, 5, 8)]
        [InlineData(10, 15, 25)]
        public void TestDodawaniaZParametrami(int x, int y, int expected)
        {
            // Act
            int wynik = x + y;

            // Assert
            Assert.Equal(expected, wynik);
        }
    }
}
