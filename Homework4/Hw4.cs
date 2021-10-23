using System;

namespace Homework4
{
    public class Hw4
    {
        public int[] CreateAnArrayWithRandom(int a)
        {
            int[] array = new int[a];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-100, 100);
            }

            return array;
        }

        public void SolveEx1()
        {
            Console.Write("Введите длину массива: ");
            int[] a = CreateAnArrayWithRandom(Convert.ToInt32(Console.ReadLine()));
            Console.Write($"Массив: ");

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }

            Console.WriteLine(" ");
            Console.Write($"Минимальный элемент: {GetMinElementInArray(a)}");
        }
        public int GetMinElementInArray(int[] a)
        {
            int min = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            return min;
        }


        public void SolveEx2()
        {
            Console.Write("Введите длину массива: ");
            int[] a = CreateAnArrayWithRandom(Convert.ToInt32(Console.ReadLine()));
            Console.Write($"Массив: ");

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }

            Console.WriteLine(" ");
            Console.Write($"Максимальный элемент: {GetMaxElementInArray(a)}");
        }
        public int GetMaxElementInArray(int[] a)
        {
            int max = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            return max;
        }


        public void SolveEx3()
        {
            Console.Write("Введите длину массива: ");
            int[] a = CreateAnArrayWithRandom(Convert.ToInt32(Console.ReadLine()));
            Console.Write($"Массив: ");

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }

            Console.WriteLine(" ");
            Console.Write($"Минимальный элемент: {GetMinElementInArray(a)}");
            Console.WriteLine(" ");
            Console.Write($"Индекс минимального элемента: {GetIndexMinElementInArray(a)}");
        }
        public int GetIndexMinElementInArray(int[] a)
        {
            int index = 0;
            int min = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                    index = i;
                }
            }
            return index;
        }


        public void SolveEx4()
        {
            Console.Write("Введите длину массива: ");
            int[] a = CreateAnArrayWithRandom(Convert.ToInt32(Console.ReadLine()));
            Console.Write($"Массив: ");

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }

            Console.WriteLine(" ");
            Console.Write($"Максимальный элемент: {GetMaxElementInArray(a)}");
            Console.WriteLine(" ");
            Console.Write($"Индекс максимального элемента: {GetIndexMaxElementInArray(a)}");
        }
        public int GetIndexMaxElementInArray(int[] a)
        {
            int index = 0;
            int max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                    index = i;
                }
            }
            return index;
        }


        public void SolveEx5()
        {
            Console.Write("Введите длину массива: ");
            int[] a = CreateAnArrayWithRandom(Convert.ToInt32(Console.ReadLine()));
            Console.Write($"Массив: ");

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }

            Console.WriteLine(" ");
            Console.Write($"Сумма элементов массива с нечетными индексами: {GetSumElementsWithEvenIdex(a)}");
        }
        public int GetSumElementsWithEvenIdex(int[] a)
        {
            int sum = 0;
            for (int i = 1; i < a.Length; i += 2)
            {
                sum += i;
            }
            return sum;
        }


        public void SolveEx6()
        {
            Console.Write("Введите длину массива: ");
            int[] a = CreateAnArrayWithRandom(Convert.ToInt32(Console.ReadLine()));
            Console.Write($"Массив: ");

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }

            int[] reverseArr = GetReverseArray(a);
            Console.WriteLine(" ");
            Console.Write($"Реверс массива: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
        public int[] GetReverseArray(int[] a)
        {
            int tmp;
            for (int i = 0; i < a.Length / 2; i++)
            {
                tmp = a[i];
                a[i] = a[a.Length - i - 1];
                a[(a.Length - i - 1)] = tmp;
            }
            return a;
        }

        public void SolveEx7()
        {
            Console.Write("Введите длину массива: ");
            int[] a = CreateAnArrayWithRandom(Convert.ToInt32(Console.ReadLine()));
            Console.Write($"Массив: ");

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }

            Console.WriteLine(" ");
            Console.Write($"Колличество нечетных элементов: {GetCommendOddElements(a)}");
        }
        public int GetCommendOddElements(int[] a)
        {
            int sum = 0;
            for (int i = 1; i < a.Length; i += 2)
            {
                sum += 1;
            }
            return sum;
        }


        public void SolveEx8()
        {
            Console.Write("Введите длину массива: ");
            int[] a = CreateAnArrayWithRandom(Convert.ToInt32(Console.ReadLine()));
            Console.Write($"Массив: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }

            int[] newArray = SwapHelvesOfArray(a);
            Console.WriteLine(" ");
            Console.Write($"Новый массив: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
        public int[] SwapHelvesOfArray(int[] a)
        {
            int half = a.Length / 2;

            for (int i = 0; i < half; i++)
            {
                int tmp = a[i];
                a[i] = a[half + i + (a.Length % 2)];
                a[half + i + (a.Length % 2)] = tmp;
            }
            return a;
        }


        public void SolveEx9()
        {
            Console.Write("Введите длину массива: ");
            int[] a = CreateAnArrayWithRandom(Convert.ToInt32(Console.ReadLine()));
            Console.Write($"Массив: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }

            int[] newArray = SortArrayInAscendingOrder(a);
            Console.WriteLine(" ");
            Console.Write($"Новый массив: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
        public int[] SortArrayInAscendingOrder(int[] a)
        {
            for (int j = 0; j < a.Length; j++)
            {
                for (int i = 0; i < a.Length - 1 - j; i++)
                {
                    int ii = i + 1;
                    if (a[i] > a[ii])
                    {
                        int tmp = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = tmp;
                    }
                }
            }
            return a;
        }


        public void SolveEx10()
        {
            Console.Write("Введите длину массива: ");
            int[] a = CreateAnArrayWithRandom(Convert.ToInt32(Console.ReadLine()));
            Console.Write($"Массив: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }

            int[] newArray = SortArrayInDescendingOrder(a);
            Console.WriteLine(" ");
            Console.Write($"Новый массив: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
        public int[] SortArrayInDescendingOrder(int[] a)
        {
            for (int j = 0; j < a.Length; j++)
            {
                int max = j;
                for (int i = 0; i < a.Length; i++)
                {

                    if (a[i] < a[max])
                    {
                        max = i;
                    }
                    int tmp = a[j];
                    a[j] = a[max];
                    a[max] = tmp;
                }
            }
            return a;
        }
    }
