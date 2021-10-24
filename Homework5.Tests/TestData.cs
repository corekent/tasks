using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5.Tests
{
    public class TestData
    {
        public static int [,] GetArrayForGetMinElementInArrayTest(int index)
        {
            return index switch
            {
               0 => new int[,] { { 1 } },
               1 => new int[,] { { 1, 2},{ -2, -1 } },
               2 => new int[,] { { 0, 1, 2},{ -3, -2, -1 } },
               _ => new int[,] { { } },
            };
        }

        public static int[,] GetArrayForGetMaxElementInArrayTest(int index)
        {
            return index switch
            {
                0 => new int[,] { { 1 } },
                1 => new int[,] { { 1, 2 }, { -2, -1 } },
                2 => new int[,] { { 0, 1, 2 }, { -1, -2, -3 } },
                _ => new int[,] { { } },
            };
        }

        public static int[,] GetArrayForGetIndexElementInArrayTest(int index)
        {
            return index switch
            {
                0 => new int[,] { { 1 } },
                1 => new int[,] { { 1, 2 }, { -2, -1 } },
                2 => new int[,] { { 0, 1, 2 }, { -1, -2, -3 } },
                _ => new int[,] { { } },
            };
        }






        public static int[,] GetArrayForGetCountOfElementsThatGreaterThanNeighborsTest(int index)
        {
            return index switch
            {
                0 => new int[,] { { 1 } },
                1 => new int[,] { { 2, 1 }, { -1, -2 } },
                2 => new int[,] { { 2, 1, 0 }, { -1, -2, -3 }, { 4, 5, -7} },
                _ => new int[,] { { } },
            };
        }

        public static int[,] GetArrayForFlipTheArrayDiagonallyTest(int index)
        {
            return index switch
            {
                0 => new int[,] { { 1 } },
                1 => new int[,] { { 2, 1 }, { -1, -2 } },
                2 => new int[,] { { 2, 1, 0 }, { -1, -2, -3 }, { 4, 5, -7 } },
                _ => new int[,] { { } },
            };
        }

        public static int[,] GetArrayForExpectedFlipTheArrayDiagonallyTest(int index)
        {
            return index switch
            {
                0 => new int[,] { { 1 } },
                1 => new int[,] { { 2, -1 }, { 1, -2 } },
                2 => new int[,] { { 2, -1, 4 }, { 1, -2, 5 }, { 0, -3, -7 } },
                _ => new int[,] { { } },
            };
        }
    }
}
