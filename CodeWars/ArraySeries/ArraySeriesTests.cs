using NUnit.Framework;

namespace CodeWars.ArraySeries
{
    [TestFixture]
    public class ArraySeriesTests
    {
        [TestCase(2, 1, 2)]
        [TestCase(22, 5, 4, 2, 3)]
        [TestCase(342, 12, 6, 10, 26, 3, 24)]
        [TestCase(74, 9, 2, 8, 7, 5, 4, 0, 6)]
        public void MinSum(int expected, params int[] a)
        {
            Assert.That(ArraySeries.MinSum(a), Is.EqualTo(expected));
        }

        [TestCase(02, 2, 3, 1, 2)]
        [TestCase(07, 3, 15, 20, 7, 10, 4, 3)]
        [TestCase(-1, 4, -5, -1, -6, -18)]
        [TestCase(-2, 5, -102, -16, -1, -2, -367, -9)]
        [TestCase(02, 4, 2, 169, 13, -5, 0, -1)]
        public void NthSmallest(int expected, int pos, params int[] a)
        {
            Assert.That(ArraySeries.NthSmallest(a, pos), Is.EqualTo(expected));
        }

        [Test]
        public void MapProduct()
        {
            Assert.That(ArraySeries.MaxProduct(new[] {4, 3, 5}, 2), Is.EqualTo(20));
            Assert.That(ArraySeries.MaxProduct(new[] {10, 8, 7, 9}, 3), Is.EqualTo(720));
            Assert.That(ArraySeries.MaxProduct(new[] {8, 6, 4, 6}, 3), Is.EqualTo(288));

//            Test.assertEquals(maxProduct([10,8,7,9], 3), 720);
//            Test.assertEquals(maxProduct([8,6,4,6], 3), 288);
//            Test.assertEquals(maxProduct([10,2,3,8,1,10,4], 5), 9600);
//            Test.assertEquals(maxProduct([13,12,-27,-302,25,37,133,155,-14], 5), 247895375);
//            Test.assertEquals(maxProduct([-4,-27,-15,-6,-1], 2), 4);
//            Test.assertEquals(maxProduct([-17,-8,-102,-309], 2), 136);
//            Test.assertEquals(maxProduct([10,3,-27,-1], 3), -30);
//            Test.assertEquals(maxProduct([14,29,-28,39,-16,-48], 4), -253344);
//            Test.assertEquals(maxProduct([1], 1), 1);
        }

        [Test]
        public void MinSumEmptyInput()
        {
            var a = new int[] { };
            Assert.That(ArraySeries.MinSum(a), Is.EqualTo(0));
        }
    }
}