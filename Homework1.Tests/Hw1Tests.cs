using NUnit.Framework;

namespace Homework1.Tests
{
    public class Hw1Tests
    {
        private Hw1 _hw1;

        [SetUp]
        public void Setup()
        {
            _hw1 = new Hw1();
        }

        //arrange
        //act
        //assert

        [TestCase(5, 7, 37.0)]
        public void MathTest(int a, int b, double c)
        {
            //arrange

            //act
            double actual = _hw1.Math(a, b);
            //assert
            Assert.AreEqual(c, actual);
        }

        [TestCase(16, 5, 3)]
        public void DivisionTest(int numerator, int denominator, int value)
        {
            //arrange
            //act
            int actual = _hw1.Division(numerator, denominator);
            //assert
            Assert.AreEqual(value, actual);
        }

        [TestCase(16, 5, 1)]
        public void GetTheRemainderOfDivisionTest(int numerator, int denominator, int remainder)
        {
            //arrange
            //act
            int actual = _hw1.GetTheRemainderOfDivision(numerator, denominator);
            //assert
            Assert.AreEqual(remainder, actual);
        }

        [TestCase(2, 5, 10, 0.25)]
        public void GetXTest(double a, double b, double c, double x)
        {
            //arrange
            //act
            double actual = _hw1.GetX(a, b, c);
            //assert
            Assert.AreEqual(x, actual);
        }


        [TestCase(1, 1, 2, 2, 1)]
        public void GetTheCoefficientKTest(double y1, double x1, double y2, double x2, double k)
        {
            //arrange
            //act
            double actual = _hw1.GetTheCoefficientK(y1, x1, y2, x2);
            //assert
            Assert.AreEqual(k, actual);
        }


        [TestCase(1, 1, 2, 2, 1, 0)]
        public void GetTheCoefficientBTest(double y1, double x1, double y2, double x2, double k, double b)
        {
            //arrange
            //act
            double actual = _hw1.GetTheCoefficientB(y1, x1, y2, x2, k);
            //assert
            Assert.AreEqual(b, actual);

        }
    }
}