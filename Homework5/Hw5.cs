using System;

namespace Homework5
{
    public class Hw5
    {
        public int[,] CreateAnArrayWithRandom(int b, int c)
        {
            int[,] a = new int[b, c];
            Random rnd = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = rnd.Next(-100, 100);
                }
            }
            return a;
        }

        public void SolveEx1()
        {
            Console.WriteLine("Введите размер массива: ");

            int[,] a = CreateAnArrayWithRandom(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine($"Массив: ");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Минимальный элемент массива: {GetMinElementInArray(a)}");
        }
        public int GetMinElementInArray(int[,] a)
        {
            int min = a[0, 0];

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] < min)
                    {
                        min = a[i, j];
                    }
                }
            }
            return min;
        }


        public void SolveEx2()
        {
            Console.WriteLine("Введите размер массива: ");

            int[,] a = CreateAnArrayWithRandom(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine($"Массив: ");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Максимальный элемент массива: {GetMaxElementInArray(a)}");
        }
        public int GetMaxElementInArray(int[,] a)
        {
            int max = a[0, 0];

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] > max)
                    {
                        max = a[i, j];
                    }
                }
            }
            return max;
        }


        public void SolveEx3()
        {
            Console.WriteLine("Введите размер массива: ");

            int[,] a = CreateAnArrayWithRandom(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine($"Массив: ");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine($"Минимальный элемент массива: {GetMinElementInArray(a)}");
            Console.Write($"Индекс минимального элемента: [{GetIndexMinElementInArray(a)}]");
        }
        public string GetIndexMinElementInArray(int[,] a)
        {
            int min = a[0, 0];
            int c = 0;
            int b = 0;
            string answer;

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] < min)
                    {
                        min = a[i, j];
                        c = i;
                        b = j;
                        answer = $"{c}, {b}";
                    }
                }
            }
            return $"{c}, {b}";
        }



        public void SolveEx4()
        {
            Console.WriteLine("Введите размер массива: ");

            int[,] a = CreateAnArrayWithRandom(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine($"Массив: ");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine($"Максимальный элемент массива: {GetMaxElementInArray(a)}");
            Console.Write($"Индекс максимального элемента: [{GetIndexMaxElementInArray(a)}]");
        }
        public string GetIndexMaxElementInArray(int[,] a)
        {
            int max = a[0, 0];
            int c = 0;
            int b = 0;
            string answer;

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] > max)
                    {
                        max = a[i, j];
                        c = i;
                        b = j;
                        answer = $"{c}, {b}";
                    }
                }
            }
            return $"{c}, {b}";
        }


        public void SolveEx5()
        {
            Console.WriteLine("Введите размер массива: ");

            int[,] a = CreateAnArrayWithRandom(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine($"Массив: ");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine($"Колличество элементов, которые больше своих соседей одновременно: {GetCountOfElementsThatGreaterThanNeighbors(a)}");
        }
        public int GetCountOfElementsThatGreaterThanNeighbors(int[,] a)
        {
            int sum = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if ((j == a.GetLength(1) - 1 || a[i, j] > a[i, j + 1]) &&
                        (j == 0 || a[i, j] > a[i, j - 1]) &&
                        (i == a.GetLength(0) - 1 || a[i, j] > a[i + 1, j]) &&
                        (i == 0 || a[i, j] > a[i - 1, j]))
                    {
                        sum++;
                    }
                }
            }
            return sum;
        }


        public void SolveEx6()
        {
            Console.WriteLine("Введите размер массива: ");

            int[,] a = CreateAnArrayWithRandom(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine($"Массив: ");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Новый массив: ");
            a = FlipTheArrayDiagonally(a);
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
        public int[,] FlipTheArrayDiagonally(int[,] a)
        {
            for (int i = 1; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < i; j++)
                {
                    int tmp = a[i, j];
                    a[i, j] = a[j, i];
                    a[j, i] = tmp;
                }
            }
            return a;
        }
    }
}
