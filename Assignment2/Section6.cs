using System;

namespace Assignment2
{
    public class Section6
    {
        public static void Run()
        {
            Console.WriteLine("\n--- Section 7: Conditional Statements ---");

            Console.Write("Enter an integer number: ");
            int x = int.Parse(Console.ReadLine());

            if (x > 0)
                Console.WriteLine("Positive");
            else if(x<0)
                Console.WriteLine("Negative ");
            else
                Console.WriteLine("Zero");

            //var result = x switch {
              //  0 => "zero",
                //> 0 => "positive",
                //< 0 => "negative"
            //};

        }
    }
}
