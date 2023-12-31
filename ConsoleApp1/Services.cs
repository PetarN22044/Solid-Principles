﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Services
    {
        public List<int> numbers = new List<int>();
        public void GetStats()
        {
            Console.WriteLine("Welcome to the app!");
            Console.WriteLine("Enter 5 numbers:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter number:");
                numbers.Add(int.Parse(Console.ReadLine()));
            }
            Console.Write("You entered: ");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Stats:");
            int even = numbers.Where(x => x % 2 == 0).Count();
            Console.WriteLine($"Even numbers: {even}");

            int odd = numbers.Count - even;
            Console.WriteLine($"Odd numbers: {odd}");

            int positive = numbers.Where(x => x >= 0).Count();
            Console.WriteLine($"Positive numbers: {positive}");

            int negative = numbers.Count - positive;
            Console.WriteLine($"Negative numbers: {negative}");

            int sum = numbers.Sum();
            Console.WriteLine($"Sum of numbers: {sum}");
        }
    }
    public class Numbers
    {
        public List<int> numbers = new List<int>();

        public void EnterNumbers()
        {
            Console.WriteLine("Welcome to the app!");
            Console.WriteLine("Enter 5 numbers:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter number:");
                numbers.Add(int.Parse(Console.ReadLine()));
            }
        }

        public void PrintNumbers()
        {
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
        }

        public void Stats()
        {
            Console.WriteLine("Stats:");
            int even = numbers.Where(x => x % 2 == 0).Count();
            Console.WriteLine($"Even numbers: {even}");

            int odd = numbers.Count - even;
            Console.WriteLine($"Odd numbers: {odd}");

            int positive = numbers.Where(x => x >= 0).Count();
            Console.WriteLine($"Positive numbers: {positive}");

            int negative = numbers.Count - positive;
            Console.WriteLine($"Negative numbers: {negative}");

            int sum = numbers.Sum();
            Console.WriteLine($"Sum of numbers: {sum}");
        }
    }
}
