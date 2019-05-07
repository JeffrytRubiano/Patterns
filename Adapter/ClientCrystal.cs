namespace Adapter
{
    public class ClientCrystal
    {
        private readonly ICrystalReport report;

        public ClientCrystal(ICrystalReport report)
        {
            this.report = report;
        }

        public string Generete() => report.Print();
    }
}