using System;

namespace Builder
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Creating invoice with default builder...");

            var invoice = new InvoiceBuildDirector(
                        new DefaultBranchInvoiceBuilder()
                ).Build();

            Console.WriteLine("------------------------");
            Console.WriteLine("+ Invoice was created: +");
            Console.WriteLine("------------------------");
            Console.WriteLine($"Id:     {invoice.Id}");
            Console.WriteLine($"Date:   {invoice.Date}");
            Console.WriteLine($"Adress: {invoice.Adress}");
            Console.WriteLine($"Value:  {invoice.Value}");
            Console.WriteLine("------------------------");
            Console.Read();
        }
    }
}