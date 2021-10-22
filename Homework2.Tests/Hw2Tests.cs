using NUnit.Framework;

namespace Homework2.Tests
{
    public class Hw2Tests

    {
        private Hw2 _hw2;

        [SetUp]
        public void Setup()
        {
            _hw2 = new Hw2();
        }

        [TestCase(4, 3, "Четверть 1")]
        public void GetAQuarterTest(int x, int y, string c)
        {
            //arrange

            //act
            string actual = _hw2.GetAQuarter(x, y);
            //assert
            Assert.AreEqual(c, actual);
        }

        [TestCase(5, 4, 3, "5, 4, 3")]
        public void RearrengingValuesInDescendingOrderTest(int a, int b, int c, string g)
        {
            //arrange

            //act
            string actual = _hw2.RearrengingValuesInDescendingOrder(a, b, c);
            //assert
            Assert.AreEqual(g, actual);
        }

        [TestCase(5, -2, -3, 64.0)]
        public void GetADiscriminantTest(int a, int b, int c, double discriminant)
        {
            //arrange

            //act
            double actual = _hw2.GetADiscriminant(a, b, c);
            //assert
            Assert.AreEqual(discriminant, actual);
        }

        [TestCase(5, -2, 64.0, "x1 = -0,6; x2 = 1")]
        public void GetASolutionToTheQuadraticEquationTest(int a, int b, double d, string answer)
        {
            //arrange

            //act
            string actual = _hw2.GetASolutionToTheQuadraticEquation(a, b, d);
            //assert
            Assert.AreEqual(answer, actual);
        }


        [TestCase(11, "Результат: eleven")]
        public void ConvertANamberToARecordTest(int a, string answer)
        {
            //arrange

            //act
            string actual = _hw2.ConvertANamberToARecord(a);
            //assert
            Assert.AreEqual(answer, actual);
        }


    }
}