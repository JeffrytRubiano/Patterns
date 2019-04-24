using System;

namespace ObjectPool
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------------------------");
            var poolResources = new Pool<Resource>(() => new Resource());
            Console.WriteLine(" Creating object pool of resources.");
            var available = poolResources.Get();
            Console.WriteLine($"  Object Id { available.GetId() }");
            Console.WriteLine("Asking for one object to the pool...");
            var availableTwo = poolResources.Get();
            Console.WriteLine($"  Object Id { availableTwo.GetId() }");
            Console.WriteLine(" It's the same object.");
            
            Console.WriteLine(" Coming back the first object asked...");
            poolResources.PutBack(available);

            Console.WriteLine("Asking ...");
            var availableFour = poolResources.Get();
            Console.WriteLine($"  Object Id { availableFour.GetId() }");
            Console.WriteLine("----------------------------------------------------------");
        }
    }
}