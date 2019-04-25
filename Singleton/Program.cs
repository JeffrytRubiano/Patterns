using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Asking for an instance...");
            var instance = SingletonPorfolio.Instance;
            Console.WriteLine($" {instance.GetId()}");
            Console.WriteLine("Try to ask for an instance...");
            var instanceClone = SingletonPorfolio.Instance;
            Console.WriteLine($" {instanceClone.GetId()}");
            Console.WriteLine("It's the same instance!");
        }
    }
}
