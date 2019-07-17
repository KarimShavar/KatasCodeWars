using NUnit.Framework;

namespace CodeWars.FindTheOddInt
{
    [TestFixture]
    public class FindItTests
    {
        [Test]
        public void FindItReturnsOddNumberInSequence()
        {
            // Arrange
            var seq = new[] {20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5};

            // Act
            var actual = FindTheOddInt.FindIt(seq);

            // Assert
            Assert.That(actual, Is.EqualTo(5));
        }
    }
}