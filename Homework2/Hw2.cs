using System;

namespace Homework2
{
    public class Hw2
    {
        public void SolveEx2()
        {
            int x = EnteringNumber("Введите Х: ");
            int y = EnteringNumber("Введите У: ");
            Console.WriteLine(GetAQuarter(x, y));
        }               
        public int EnteringNumber(string message)
        {
            Console.Write(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        public string GetAQuarter(int x, int y)
        {            
            if ((x >= 0) && (y >= 0))
            {
                return "Четверть 1";
            }
            else if ((x < 0) && (y >= 0))
            {
                return "Четверть 2";
            }
            else if ((x < 0) && (y < 0))
            {
                return "Четверть 3";
            }
            else
            {
                return "Четверть 4";
            }
        }


        public void SolveEx3()
        {
            int a = EnteringNumber("Введите число 1: ");
            int b = EnteringNumber("Введите число 2: ");
            int c = EnteringNumber("Введите число 3: ");
            Console.WriteLine(RearrengingValuesInDescendingOrder(a, b, c));
        }
        public string RearrengingValuesInDescendingOrder(int a, int b, int c)
        {
            int first = a;
            int second = b;
            int third = c;

            if ((a >= b) && (b >= c))
            {
                return $"{a}, {b}, {c}";
            }
            else if ((a >= b) && (a >= c) && (b < c))
            {
                return $"{a} {c} {b}";
            }
            else if ((b > a) && (a >= c))
            {
                return $"{b} {a} {c}";
            }
            else if ((b > a) && (b >= c) && (c >= a))
            {
                return $"{b} {c} {a}";
            }
            else if ((c >= a) && (c >= b) && (b >= a))
            {
                return $"{c} {b} {a}";
            }
            else
            {
                return $"{c} {a} {b}";
            }            

        }

        public void SolveEx4()
        {
            int a = EnteringNumber("Введите A: ");
            int b = EnteringNumber("Введите B: ");
            int c = EnteringNumber("Введите C: ");
            double discriminant = GetADiscriminant(a, b, c);
            Console.WriteLine(GetASolutionToTheQuadraticEquation(a, b, discriminant));

        }
        public double GetADiscriminant(int a, int b, int c)
        {
            return (b*b - (4.0 * a * c));
        }
        public string GetASolutionToTheQuadraticEquation(int a, int b, double d)
        {
            if (d < 0)
            {
                return "Действительных коней нет";
            }
            else if (d == 0)
            {
                return $"x = {(-b) / (2 * a)}";
            }
            else
            {
                return $"x1 = {(- b - Math.Sqrt(d)) / (2 * a)}; x2 = {(- b + Math.Sqrt(d)) / (2 * a)}";
            }
        }


        public void SolveEx5()
        {
            int a = EnteringNumber("Введите число от 10 до 99: ");            
            Console.WriteLine(ConvertANamberToARecord(a));
        }
        public string ConvertANamberToARecord(int a)
        {
            int wholePart = a / 10;
            int remains = a % 10;
            string figure1;
            string figure2;
            if (wholePart == 1 && remains < 3)
            {
                figure1 = a switch
                {
                    10 => "ten",
                    11 => "eleven",
                    _ => "twelve",
                };
            }
            else if (wholePart == 1 && remains > 2)
            {
                figure1 = remains switch
                {
                    3 => "firteen",
                    4 => "fourteen",
                    5 => "fifteen",
                    6 => "sixteen",
                    7 => "seventeen",
                    8 => "eighteen",
                    9 => "nineteen",
                    _ => "-",
                };
            }
            else if (wholePart != 1)
            {
                figure1 = wholePart switch
                {
                    2 => "twenty",
                    3 => "fhirty",
                    4 => "forty",
                    5 => "fifty",
                    6 => "sixty",
                    7 => "seventy",
                    8 => "eighty",
                    9 => "ninety",
                    _ => "-",
                };
            }
            else
            {
                figure1 = "-";
            }


            if (remains > 0 && wholePart > 1)
            {
                figure2 = remains switch
                {
                    1 => "one",
                    2 => "two",
                    3 => "three",
                    4 => "four",
                    5 => "five",
                    6 => "six",
                    7 => "seven",
                    8 => "eight",
                    _ => "nine",
                };
            }
            else
            {
                figure2 = " ";
            }

            if (wholePart > 1 && remains != 0)
            {
                return $"Результат: {figure1}-{figure2}";
            }
            else
            {
                return $"Результат: {figure1}";
            }
        }
    }
}
