﻿using System;
using System.Collections.Generic; // Imports? .NET SimpleStack<TypeHandler> Class

namespace WiredBrainCoffee.StackApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StackDoubles();
            StackStrings();
            Console.ReadLine();
        }

        private static void StackDoubles()
        {
            var stack = new Stack<double>();
            stack.Push(1.2);
            stack.Push(2.8);
            stack.Push(3.0);
            //stack.Push(5.0);

            double sum = 0.0;

            while (stack.Count > 0)
            {
                double item = stack.Pop();
                Console.WriteLine($"Item: {item}");

                sum += item;
            }

            Console.WriteLine($"Sum: {sum}");
        }

        private static void StackStrings()
        {
            var stack = new Stack<string>();
            stack.Push("Wired Brain Coffee");
            stack.Push("Pluralsight");

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}