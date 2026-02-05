using System;

namespace Assignment2
{
    public class Section5
    {
        public static void Run()
        {
            Console.WriteLine("\n--- Section 6: Nullable Types ---");

            int? n = null;
            int value = n ?? -1;
            string? s="Nullable Types";
            int? length = s?.Length;

            Console.WriteLine(value);
            Console.WriteLine(length);
        }
    }
}
