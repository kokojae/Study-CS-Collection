using System;
using System.Collections.Generic;

namespace Iterators
{
    class Program
    {
        static void Main(string[] args)
        {
            ListEvenNumbers();
        }

        private static void ListEvenNumbers()
        {
            foreach (int number in EvenSequence(5,18))
            {
                Console.Write(number.ToString() + " ");
            }
            Console.WriteLine();
        }

        private static IEnumerable<int> EvenSequence(
            int firstNumber, int lastNumber)
        {
            // 범위에서 짝수를 산출하십시오.
            for (var number = firstNumber; number <= lastNumber; number++)
            {
                if (number % 2 == 0)
                {
                    yield return number;
                }
            }
        }
    }
}
