using NUnit.Framework;

namespace CodeWars.DoubleCola
{
    [TestFixture]
    public class DoubleColaTests
    {
        public void DoubleReturnsWhosNextFromSpecificQueueNumber()
        {
            // Arrange
            var names = new[] {"Sheldon", "Leonard", "Penny", "Rajesh", "Howard"};
            var n = 1;

            // Act

            // Assert
            Assert.AreEqual("Sheldon", DoubleCola.WhoIsNext(names, n));
        }
    }
}