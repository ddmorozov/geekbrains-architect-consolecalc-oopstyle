using System;

namespace ConsoleCalcOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter expression: ");
            string input = Console.ReadLine();
            // to postfix notation
            var Postfix = new PostfixConverter(input);
            string postfixString = Postfix.Result;
            Console.WriteLine(postfixString);
            // get result
            var Compute = new PostfixCompute(postfixString);
            decimal computeResult = Compute.Result;
            Console.WriteLine(computeResult);
            //
            Console.Write("\nPress any key to exit...");
            Console.ReadKey(true);
        }
    }
}
