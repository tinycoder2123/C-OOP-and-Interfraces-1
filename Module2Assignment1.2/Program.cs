using System;

namespace Module2Assignment1._2
{
    class Program
    {
        public static void PrimeFactors(int num)
        {
            Console.Write($"Prime Factors of {num} are:  ");
            while (num % 2 == 0)
            {
                Console.Write("2 ");
                num /= 2;
            }
            for (int i = 3; i <= Math.Sqrt(num); i += 2)
            {
                while (num % i == 0)
                {
                    Console.Write($"{i}  ");
                    num /= i;
                }
            }
            if (num > 2)
            {
                Console.Write($"{num} ");
            }
        }
        static void Main()
        {
            Console.Write("Enter a number greater than 1: ");
            if (int.TryParse(Console.ReadLine(), out int num) && num > 1)
            {
                PrimeFactors(num);
            }
            else
            {
                Console.WriteLine("Invalid input!!");
            }
        }
    }
}
