using System;

namespace Prototype
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Creating base objects...");
            var baseFinancial = new FinancialReport();
            Console.WriteLine($" Financial Report: {baseFinancial.GetId()}");
            var baseLogistic = new LogisticReport();
            Console.WriteLine($" Logistic Report:  {baseLogistic.GetId()}");

            Console.WriteLine("Cloning objects...");
            var cloneFinancial = baseFinancial.Clone() as FinancialReport;
            Console.WriteLine($" Financial  Clone: {cloneFinancial.GetId()}");
            var cloneLogistic = baseLogistic.Clone() as LogisticReport;
            Console.WriteLine($" Logistic  Clone:  {cloneLogistic.GetId()}");
            Console.WriteLine("----------------------------------------------------------");
        }
    }
}