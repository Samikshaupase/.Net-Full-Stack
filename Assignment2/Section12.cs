using System;

namespace Assignment2
{
    public class Section12
    {
        public static void Run()
        {
            Console.WriteLine("\n--- Section 12: Comments ---");

            // This is a single-line comment

            /* This is a
               multi-line comment */

            Console.WriteLine("Comments example");

            // Creating an object of Person class
            Person p = new Person { Name = "Samiksha" };
            Console.WriteLine($"Person Name: {p.Name}");
        }
    }

    /// <summary>
    /// Represents a person.
    /// </summary>
    public class Person
    {
        public required string Name { get; set; }
    }
}
