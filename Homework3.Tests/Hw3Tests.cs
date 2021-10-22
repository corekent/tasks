using NUnit.Framework;

namespace Homework3.Tests
{
    public class Hw3Tests
    {
        private Hw3 _hw3;

        [SetUp]
        public void Setup()
        {
            _hw3 = new Hw3();
        }

        [TestCase(5, 2, "5^2 = 25")]
        public void GetANamberToAPoverTest(int a, int b, string answer)
        {
            //arrange

            //act
            string actual = _hw3.GetANamberToAPover(a, b);
            //assert
            Assert.AreEqual(answer, actual);
        }


        [TestCase(250, "250 500 750 ")]
        public void SearchForDivisorsTest(int a, string divisors)
        {
            //arrange

            //act
            string actual = _hw3.SearchForDivisors(a);
            //assert
            Assert.AreEqual(divisors, actual);
        }


        [TestCase(30, 5)]
        public void GetCountOfElemrntsWhoseSquareIsLessThanATest(int a, int b)
        {
            //arrange

            //act
            int actual = _hw3.GetCountOfElemrntsWhoseSquareIsLessThanA(a);
            //assert
            Assert.AreEqual(b, actual);
        }


        [TestCase(75, 25)]
        public void GetLargestDivisorTest(int a, int divisor)
        {
            //arrange
            //act
            int actual = _hw3.GetLargestDivisor(a);
            //assert
            Assert.AreEqual(divisor, actual);
        }


        [TestCase(1, 15, 21)]
        public void GetTheSumOfElementsThatAreDivisibleBySevenTest(int a, int b, int sum)
        {
            //arrange
            //act
            int actual = _hw3.GetTheSumOfElementsThatAreDivisibleBySeven(a, b);
            //assert
            Assert.AreEqual(sum, actual);
        }


        [TestCase(5, 5)]
        public void GetNumberOfTheFibonacciSeriesByNumberTest(int n, int c)
        {
            //arrange
            //act
            int actual = _hw3.GetNumberOfTheFibonacciSeriesByNumber(n);
            //assert
            Assert.AreEqual(c, actual);
        }


        [TestCase(75, 50, 25)]
        public void GetGreatestCommonDivisorTest(int a, int b, int answer)
        {
            //arrange
            //act
            int actual = _hw3.GetGreatestCommonDivisor(a, b);
            //assert
            Assert.AreEqual(answer, actual);
        }


        [TestCase(8, 2)]
        public void GetTheRoofOfANamberUsingTheHaifDivisionMetodTest(int n, double b)
        {
            //arrange
            //act
            double actual = _hw3.GetTheRoofOfANamberUsingTheHaifDivisionMetod(n);
            //assert
            Assert.AreEqual(b, actual);
        }


        [TestCase(1298, 2)]
        public void GetCountEvenElementsOfANumberTest(int a, int b)
        {
            //arrange
            //act
            int actual = _hw3.GetCountEvenElementsOfANumber(a);
            //assert
            Assert.AreEqual(b, actual);
        }


        [TestCase(1298, 2)]
        public void GetCountOddElementsOfANumberTest(int a, int b)
        {
            //arrange
            //act
            int actual = _hw3.GetCountOddElementsOfANumber(a);
            //assert
            Assert.AreEqual(b, actual);
        }


        [TestCase(123456, "654321")]
        public void GetReverseOfANumberTest(int a, string reverse)
        {
            //arrange

            //act
            string actual = _hw3.GetReverseOfANumber(a);
            //assert
            Assert.AreEqual(reverse, actual);
        }


        [TestCase(123, 345, "Да")]
        public void GetCommonElementsOfNumberTest(int a, int b, string answer)
        {
            //arrange

            //act
            string actual = _hw3.GetCommonElementsOfNumber(a, b);
            //assert
            Assert.AreEqual(answer, actual);
        }
    }
}