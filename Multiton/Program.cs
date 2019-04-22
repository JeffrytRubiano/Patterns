using System;

namespace Multiton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Create Connector object: standard");
            var standard = MultitonConnectors.GetInstance(ConnectorType.Standard);
            Console.WriteLine("The object has been created.");
            Console.WriteLine($" Object ID: {standard.GetObjectId().ToString()}");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Call again to try to create the object.");
            var standardTwo = MultitonConnectors.GetInstance(ConnectorType.Standard);
            Console.WriteLine("The object hasn't been created. It was used the before object. ");
            Console.WriteLine($" Object ID: {standardTwo.GetObjectId().ToString()}");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Create Connector object: custom");
            var custom = MultitonConnectors.GetInstance(ConnectorType.Custom);
            Console.WriteLine("The object has been created.");
            Console.WriteLine($" Object ID: {custom.GetObjectId().ToString()}");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Call again to try to create the Custom object.");
            var customTwo = MultitonConnectors.GetInstance(ConnectorType.Custom);
            Console.WriteLine("The object hasn't been created. It was used the before object. ");
            Console.WriteLine($" Object ID: {customTwo.GetObjectId().ToString()}");
            Console.WriteLine("----------------------------------------------------------");
        }
    }
}
