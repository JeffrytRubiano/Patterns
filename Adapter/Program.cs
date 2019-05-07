using System;

namespace Adapter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // The object reporting services will be translated to crystal report.
            ICrystalReport adaptee = new ReportingServicesAdapter(new ReportingServices());

            // This client only understands the object type: ICrystalReport
            var report = new ClientCrystal(adaptee);

            Console.WriteLine(report.Generete());
        }
    }
}