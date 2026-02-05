using System;
using System.Threading.Tasks
;
namespace Assignment2
{
    public class Section1 {
        public static void Run(string[] args) {
            Console.WriteLine(args.Length > 0 ? args[0] : "no args");
            Console.WriteLine("Top-level app started");
        }
       // public static async Task RunAsync()
        //{
          //  Console.WriteLine("Section 1 started");
            //await Task.Delay(10);
            //Console.WriteLine("Section 1 finished after delay");
        //}
    }
}