using System;

namespace Homework3
{
    public class Hw3
    {
        public void SolveEx1()
        {
            int a = EnteringNumber("Введите А: ");
            int b = EnteringNumber("Введите В: ");
            Console.WriteLine(GetANamberToAPover(a, b));
        }
        public int EnteringNumber(string message)
        {
            Console.Write(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        public string GetANamberToAPover(int a, int b)
        {
            return $"{a}^{b} = {Math.Pow(a, b)}";
        }


        public void SolveEx2()
        {
            int a = EnteringNumber("Введите А: ");
            Console.WriteLine(SearchForDivisors(a));
        }
        public string SearchForDivisors(int a)
        {
            string divisors = "";
            for (int divider = 1; divider < 1000; divider++)
            {
                int resoult = divider % a;
                if (resoult == 0)
                {
                    divisors += divider + " ";
                }
            }
            return divisors;
        }


        public void SolveEx3()
        {
            int a = EnteringNumber("Введите А: ");
            Console.WriteLine($"Колличество элементов, квадрат которых меньше чем А: {GetCountOfElemrntsWhoseSquareIsLessThanA(a)}");
        }
        public int GetCountOfElemrntsWhoseSquareIsLessThanA(int a)
        {
            int b = 0;
            for (int square = 1; square < Math.Sqrt(a); square++)
            {
                b++;
            }
            return b;
        }


        public void SolveEx4()
        {
            int a = EnteringNumber("Введите А: ");
            Console.WriteLine(GetLargestDivisor(a));
        }
        public int GetLargestDivisor(int a)
        {
            int divisor = 0;
            for (int i = 1; i < a; i++)
            {
                if (a % i == 0)
                {
                    divisor = i;
                }
            }
            return divisor;
        }

        public void SolveEx5()
        {
            int a = EnteringNumber("Введите А: ");
            int b = EnteringNumber("Введите B: ");
            Console.WriteLine($"Результат: {GetTheSumOfElementsThatAreDivisibleBySeven(a, b)}");
        }
        public int GetTheSumOfElementsThatAreDivisibleBySeven(int a, int b)
        {
            int sum = 0;
            if (a > b)
            {                
                for (int i = b + 1; i < a; i++)
                {
                    if (i % 7 == 0)
                    {
                        sum += i;
                    }
                }
                return sum;
            }
            else
            {                
                for (int i = a + 1; i < b; i++)
                {
                    if (i % 7 == 0)
                    {
                        sum += i;
                    }
                }
                return sum;
            }
        }


        public void SolveEx6()
        {
            int n = EnteringNumber("Введите N: ");
            Console.WriteLine($"Результат: {GetNumberOfTheFibonacciSeriesByNumber(n)}");
        }
        public int GetNumberOfTheFibonacciSeriesByNumber(int n)
        {
            int a = 1;
            int b = 1;
            int c;
            do
            {
                c = a + b;
                a = b;
                b = c;
                n -= 1;
            }
            while (n - 2 != 0);
            return c;
        }


        public void SolveEx7()
        {
            int a = EnteringNumber("Введите A: ");
            int b = EnteringNumber("Введите B: ");
            Console.WriteLine($"Наибольший общий делитель: {GetGreatestCommonDivisor(a, b)}");
        }
        public int GetGreatestCommonDivisor(int a, int b)
        {
            int c;
            if (a > b)
            {
                if (a % b > 0)
                {
                    do
                    {
                        c = a % b;
                        a = b;
                        b = c;
                    }
                    while (c == 0);
                    return b;
                }
                else
                {
                    c = b;
                }
                return c;
            }
            else if (a < b)
            {

                if (b % a > 0)
                {
                    do
                    {
                        c = b % a;
                        b = a;
                        a = c;
                    }
                    while (c == 0);
                    return a;
                }
                else
                {
                    c = b;
                }
                return c;
            }
            else if (a == b)
            {
                return a;
            }
            else
            {
                return 1;
            }
        }


        public void SolveEx8()
        {
            double n = Convert.ToDouble(EnteringNumber("Введите целое положительное число, которое является кубом целого числа: "));
            
            Console.WriteLine($"{n} является кубом числа {GetTheRoofOfANamberUsingTheHaifDivisionMetod(n)}");
        }
        public double GetTheRoofOfANamberUsingTheHaifDivisionMetod(double n)
        {
            double a = n;
            double c;
            double b;
            if (n >= 0)
            {
                do
                {
                    b = a / 2;
                    c = b * b * b;
                    a = b;
                }
                while (n != c);
                return b;
            }
            else
            {
                return 0-0;
            }
        }


        public void SolveEx9 ()
        {
            int a = EnteringNumber("Введите число: ");
            Console.WriteLine($"количество четных цифр: {GetCountEvenElementsOfANumber(a)}");
            Console.WriteLine($"количество нечетных цифр: {GetCountOddElementsOfANumber(a)}");
        }
        public int GetCountEvenElementsOfANumber(int a)
        {
            int evens = 0;
            
            do
            {               
                if (a % 2 == 0)
                {
                    evens += 1;
                }
                a /= 10;
            }
            while (a != 0);
            return evens;
        }
        public int GetCountOddElementsOfANumber(int a)
        {
            int odds = 0;

            do
            {

                if (a % 10 == 0)
                {
                    odds += 1;
                }
                else if (a % 2 == 1)
                {
                    odds += 1;
                }
                a /= 10;
            }
            while (a != 0);
            return odds;
        }


        public void SolveEx10()
        {
            int a = EnteringNumber("Введите число: ");
            Console.WriteLine($"Ваше число наоборот:{GetReverseOfANumber(a)}");
        }
        public string GetReverseOfANumber(int a)
        {
            int b;
            string reverse = "";
            do
            {
                b = a % 10;
                string number = Convert.ToString(b);
                reverse += number;
                a /= 10;

            }
            while (a != 0);
            return reverse;
        }


        public void SolveEx11()
        {
            int a = EnteringNumber("Введите число: ");
            
            for (int i = 1; i != a; i++)
            {
                int tmp = i;
                int sumEven = 0;
                int sumOdd = 0;

                if (i % 10 > 9)
                {
                    do
                    {
                        tmp /= 10;
                    }
                    while (tmp > 9);
                }

                if (tmp % 2 == 0)
                {
                    sumEven += tmp;
                }
                else
                {
                    sumOdd += tmp;
                }

                if (sumEven > sumOdd)
                {
                    Console.WriteLine(i);
                }
            }
        }
              
        
      
        public void SolveEx12()
        {
            int a = EnteringNumber("Введите число 1: ");
            int b = EnteringNumber("Введите число 2: ");
            Console.WriteLine($"Ответ: {GetCommonElementsOfNumber(a, b)}");
        }
        public string GetCommonElementsOfNumber(int a, int b)
        {
            
            int x = a;

            while (b != 0)
            {
                while (a != 0)
                {
                    if (a % 10 == b % 10)
                    {
                        return "Да";                        
                    }
                    a /= 10;
                }
                b /= 10;
                a = x;
            }
            return "no";            
        }

    }
}
