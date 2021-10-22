using System;

namespace Homework1
{
    public class Hw1
    {
        public void SolveEx1()
        {
            int a = EnteringNumber("Введите число 1: ");
            int b = EnteringNumber("Введите число 2: ");
            double c = Math(a, b);
            Console.WriteLine($"Ответ: {c}");
        }
        public int EnteringNumber(string message)
        {
            Console.Write(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        public double Math(int a, int b)
        {
            double c = (5.0 * a + b * b) / (b - a);
            return c;
        }


        public void SolveEx2()
        {
            int a = EnteringNumber("Введите значение А: ");
            int b = EnteringNumber("Введите значение Б: ");

            Console.WriteLine($"Значение А: {SwapValues(a, b)}");
            Console.WriteLine($"Значение Б: {SwapValues(b, a)}");
        }
        public int SwapValues(int a, int b)
        {
            int c = a;
            a = b;
            b = c;
            return a;
        }


        public void SolveEx3()
        {
            int numerator = EnteringNumber("Числитель: ");
            int denominator = EnteringNumber("Знаменатель: ");
            Console.WriteLine($"{numerator}/{denominator} = {Division(numerator, denominator)}");
            Console.WriteLine($"Остаток от деления: {GetTheRemainderOfDivision(numerator, denominator)}");
        }
        public int Division(int numerator, int denominator)
        {
            int value = numerator / denominator;
            return value;
        }
        public int GetTheRemainderOfDivision(int numerator, int denominator)
        {
            int remainder = numerator % denominator;
            return remainder;
        }


        public void SolveEx4()
        {
            Console.WriteLine("AX+B=C");
            Console.WriteLine("Введите число А");
            double a = EnteringNumber("A=");
            Console.WriteLine("Введите число B");
            double b = EnteringNumber("B=");
            Console.WriteLine("Введите число C");
            double c = EnteringNumber("C=");

            Console.WriteLine($"X={GetX(a, b, c)}");
        }
        public double GetX(double a, double b, double c)
        {
            double x = (c - b) / a * 0.1;
            return x;
        }


        public void SolveEx5()
        {
            double y1 = EnteringNumber("Введите у1: ");
            double x1 = EnteringNumber("Введите x1: ");
            double y2 = EnteringNumber("Введите y2: ");
            double x2 = EnteringNumber("Введите x2: ");

            double k = GetTheCoefficientK(y1, x1, y2, x2);
            double b = GetTheCoefficientB(y1, x1, y2, x2, k);
            Console.WriteLine($"Уравнение прямой: y={k}*x+{b}");
        }
        public double GetTheCoefficientK(double y1, double x1, double y2, double x2)
        {
            double k = (y1 - y2) / (x1 - x2);
            return k;
        }
        public double GetTheCoefficientB(double y1, double x1, double y2, double x2, double k)
        {
            double b = y2 - k * x2;
            return b;
        }
    }
}
