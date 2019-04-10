using System;

namespace DependencyInjection
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Test connection with odbc connector...");
            var odbc = new Connection(new OdbcConnector());
            Console.WriteLine($"Test result: {odbc.TestConnection()} ");
            Console.WriteLine("");
            Console.WriteLine("Test connection with custom connector...");
            var custom = new Connection(new CustomConnector());
            Console.WriteLine($"Test result: {custom.TestConnection()} ");
            Console.Read();
        }
    }
}