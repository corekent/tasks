using NUnit.Framework;

namespace Homework5.Tests
{
    public class Hw5Tests
    {
        private Hw5 _hw5;
        [SetUp]
        public void Setup()
        {
            _hw5 = new Hw5();
        }

        [TestCase (0, 1)]
        [TestCase (1, -2)]
        [TestCase (2, -3)]        
        public void GetMinElementInArrayTest(int index, int expected)
        {
            //arrange
            int[,] arrayToTest = TestData.GetArrayForGetMinElementInArrayTest(index);
            
            //act
            int actual = _hw5.GetMinElementInArray(arrayToTest);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 1)]
        [TestCase(1, 2)]
        [TestCase(2, 2)]
        public void GetMaxElementInArrayTest(int index, int expected)
        {
            //arrange
            int[,] arrayToTest = TestData.GetArrayForGetMaxElementInArrayTest(index);

            //act
            int actual = _hw5.GetMaxElementInArray(arrayToTest);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, "0, 0")]
        [TestCase(1, "0, 1")]
        [TestCase(2, "0, 2")]
        public void GetIndexMaxElementInArrayTest(int index, string expected)
        {
            //arrange
            int[,] arrayToTest = TestData.GetArrayForGetIndexElementInArrayTest(index);

            //act
            string actual = _hw5.GetIndexMaxElementInArray(arrayToTest);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, "0, 0")]
        [TestCase(1, "1, 0")]
        [TestCase(2, "1, 2")]
        public void GetIndexMinElementInArrayTest(int index, string expected)
        {
            //arrange
            int[,] arrayToTest = TestData.GetArrayForGetIndexElementInArrayTest(index);

            //act
            string actual = _hw5.GetIndexMinElementInArray(arrayToTest);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 1)]
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        public void GetCountOfElementsThatGreaterThanNeighborsTest(int index, int expected)
        {
            //arrange
            int[,] arrayToTest = TestData.GetArrayForGetCountOfElementsThatGreaterThanNeighborsTest(index);

            //act
            int actual = _hw5.GetCountOfElementsThatGreaterThanNeighbors(arrayToTest);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        public void FlipTheArrayDiagonallyTest(int index)
        {
            //arrange
            int[,] arrayToTest = TestData.GetArrayForFlipTheArrayDiagonallyTest(index);
            int[,] expected = TestData.GetArrayForExpectedFlipTheArrayDiagonallyTest(index);

            //act
            _hw5.FlipTheArrayDiagonally(arrayToTest);

            //assert
            Assert.AreEqual(expected, arrayToTest);
        }

    }
}