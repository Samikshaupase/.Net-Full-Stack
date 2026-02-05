using System;

namespace Assignment2
{
    public class Section7
    {
        public static void Run()
        {
            Console.WriteLine("\n--- Section7 : Pattern Matching ---");

            object obj = 10;

            if (obj is int i)
                Console.WriteLine(i + 1);

            // Switch with type patterns
            Console.WriteLine(Describe(10));
            Console.WriteLine(Describe("hello"));
            Console.WriteLine(Describe(null));
            Console.WriteLine(Describe(3.14));
        }

        // Switch expression method
        static string Describe(object? obj) => obj switch
        {
            null => "none",
            int i => $"int {i}",
            string s => $"str({s})",
            _ => "other"
        };


    }
}

