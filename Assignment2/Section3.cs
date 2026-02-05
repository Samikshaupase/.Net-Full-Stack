using System;
using System.Text;

namespace Assignment2
{
    public class Section3
    {
        public static void Run()
        {
            Console.WriteLine("\n--- Section 3: String & StringBuilder ---");

            string s = "Hello" + " World";
            string template = $"User: {Environment.UserName}, Date: {DateTime.Today:d}";

            Console.WriteLine(s);
            Console.WriteLine(template);

            var sb = new StringBuilder();
            sb.Append("Line1");
            sb.AppendLine();
            sb.AppendFormat("{0} items", 5);

            Console.WriteLine(sb.ToString());
        }
    }
}
