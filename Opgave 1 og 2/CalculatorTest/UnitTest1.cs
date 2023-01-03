using MovieLibrary;

namespace CalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var calculator = new TimeCalculator();
            var minutes = 10;
            var expected = 600;

            // Act
            var result = calculator.ConvertMinutesToSeconds(minutes);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestMethod2()
        {
            // Arrange
            var calculator = new TimeCalculator();
            var minutes = -10;

            // Act
            var result = calculator.ConvertMinutesToSeconds(minutes);
        }
    }
}