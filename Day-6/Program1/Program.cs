using System;
using System.Collections;
using System.Collections.Generic;

namespace Day6_demo_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // GENERIC STACK
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            int poppedValue = stack.Pop();
            Console.WriteLine("Popped value: " + poppedValue);

            int topValue = stack.Peek();
            Console.WriteLine("Top value after peek: " + topValue);

            bool contains20 = stack.Contains(20);
            Console.WriteLine("Stack contains 20: " + contains20);

            Console.WriteLine("Current count: " + stack.Count);

            // NON-GENERIC STACK
            Stack nonGenericStack = new Stack();
            nonGenericStack.Push(100);
            nonGenericStack.Push("Hello");

            Console.WriteLine("Non-generic stack contents:");
            foreach (var item in nonGenericStack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Popping items from non-generic stack:");
            while (nonGenericStack.Count > 0)
            {
                Console.WriteLine(nonGenericStack.Pop());
            }

            nonGenericStack.Push(500);
            nonGenericStack.Push("World");
            Console.WriteLine("Top item using Peek: " + nonGenericStack.Peek());
        }
    }
}
