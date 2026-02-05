using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment2
{
    public class Section10
    {
        public static void Run()
        {
            Console.WriteLine("\n--- Section 10: Arrays & Collections ---");

            int[] arr = { 1, 2, 3 };
            foreach (int i in arr)
                Console.WriteLine(i);

            List<string> list = new List<string> { "A", "B", "C" };
            list.Add("D");

            foreach (var item in list)
                Console.WriteLine(item);
            
            List<int> listOfInts = new List<int>();
            var evens = listOfInts.Where(i => i % 2 == 0).ToArray();
        }
    }
}

