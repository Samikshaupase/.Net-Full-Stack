using System;

namespace Assignment2
{
    public class Section11
    {
        public static void Run()
        {
            Console.WriteLine("\n--- Section 11: Loops ---");

            for (int i = 1; i <= 3; i++)
                Console.WriteLine(i);

            int x = 3;
            while (x > 0)
            {
                Console.WriteLine(x);
                x--;
            }
        }
    }
}
