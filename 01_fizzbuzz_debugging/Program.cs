// Read https://en.wikipedia.org/wiki/Fizz_buzz

/*
Write a program that prints the integers from 1 to 100 (inclusive).
But:
 for multiples of three, print Fizz (instead of the number)
 for multiples of five, print Buzz (instead of the number)
 for multiples of both three and five, print FizzBuzz (instead of the number)
*/

// Expected Output:
// 1
// 2
// Fizz
// 4
// Buzz
// Fizz
// 7
// 8
// Fizz
// Buzz
// 11
// Fizz
// 13
// 14
// FizzBuzz
// 16
// 17
// ...

//NOTES: breakpoints, autos/local, conditional breakpoints

namespace _01_fizzbuzz_debugging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    PrintFizzBuzz();
                }
                else if (i % 3 == 0)
                {
                    PrintFizz();
                }
                else if (i % 5 == 0)
                {
                    PrintBuzz();
                }
                else
                {
                    PrintNumber(i);
                }
            }
            Console.ReadKey();                      
        }

        private static void PrintFizz()
        {
            Console.WriteLine("Fizz");
        }

        private static void PrintBuzz()
        {
            Console.WriteLine("Buzz");
        }

        private static void PrintFizzBuzz()
        {
            Console.WriteLine("FizzBuzz");
        }

        private static void PrintNumber(int number)
        {
            Console.WriteLine(number);
        }
    }
}