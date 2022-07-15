using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeworkLesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Factorial(int n)
            {
                IEnumerable<int> numbers = Enumerable.Range(1, n);
                int factorial = numbers.Aggregate((sum, next) => sum * next);
                return factorial;
            }

            //Fibonacci 1 
            int Fibonacci(int n)
            {
                List<int> fibonacciNumbers = new List<int> { 0, 1 };
                for (int i = 0; i < n - 2; i++)
                {
                    fibonacciNumbers.Add(fibonacciNumbers[i] + fibonacciNumbers[i + 1]);
                }
                return fibonacciNumbers[n - 1];
            }

            //Fibonacci 2
            int fibbonacciNumberToFind = 5;
            var result = Enumerable.Range(0, fibbonacciNumberToFind).Skip(2).Aggregate(new { prev = 0, current = 1 }, (prev, _) => new { prev = prev.current, current = prev.prev + prev.current }).current;

        }
    }
}
