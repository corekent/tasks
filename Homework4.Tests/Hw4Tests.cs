using NUnit.Framework;

namespace Homework4.Tests
{
    public class Hw4Tests
    {
        private Hw4 _hw4;

        [SetUp]
        public void Setup()
        {
            _hw4 = new Hw4();
        }

        [TestCase(new int[] { 1, 2, 3}, 1)]
        public void GetMinElementInArrayTest(int[] array, int expected)
        {
            //arrange

            //act
            int actual = _hw4.GetMinElementInArray(array);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, 3)]
        public void GetMaxElementInArrayTest(int[] array, int expected)
        {
            //arrange

            //act
            int actual = _hw4.GetMaxElementInArray(array);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, -5, 0 }, 3)]
        public void GetIndexMinElementInArrayTest(int[] array, int expected)
        {
            //arrange

            //act
            int actual = _hw4.GetIndexMinElementInArray(array);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, -5, 0 }, 2)]
        public void GetIndexMaxElementInArrayTest(int[] array, int expected)
        {
            //arrange

            //act
            int actual = _hw4.GetIndexMaxElementInArray(array);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, -5, 0 }, 4)]
        public void GetSumElementsWithEvenIdexTest(int[] array, int expected)
        {
            //arrange

            //act
            int actual = _hw4.GetSumElementsWithEvenIdex(array);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, -5, 0 }, new int[] { 0, -5 , 3 , 2 , 1 })]
        public void GetReverseArrayTest(int[] array, int[] expected)
        {
            //arrange

            //act
            int[] actual = _hw4.GetReverseArray(array);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, -5, 0 }, 3)]
        public void GetCommendOddElementsTest(int[] array, int expected)
        {
            //arrange

            //act
            int actual = _hw4.GetCommendOddElements(array);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, -5, 0 }, new int[] { -5, 0, 3, 1, 2 })]
        public void SwapHelvesOfArrayTest(int[] array, int[] expected)
        {
            //arrange

            //act
            int[] actual = _hw4.SwapHelvesOfArray(array);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, -5, 0 }, new int[] { -5, 0, 1, 2, 3 })]
        public void SortArrayInAscendingOrderTest(int[] array, int[] expected)
        {
            //arrange

            //act
            int[] actual = _hw4.SortArrayInAscendingOrder(array);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, -5, 0 }, new int[] { 3, 2, 1, 0, -5 })]
        public void SortArrayInDescendingOrderTest(int[] array, int[] expected)
        {
            //arrange

            //act
            int[] actual = _hw4.SortArrayInDescendingOrder(array);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}