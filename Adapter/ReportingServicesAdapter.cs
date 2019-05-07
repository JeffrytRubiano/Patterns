namespace Adapter
{
    public class ReportingServicesAdapter : ICrystalReport
    {
        private readonly IReportingServices reporting;

        public ReportingServicesAdapter(IReportingServices reporting)
        {
            this.reporting = reporting;
        }

        public string Print()
        {
            // translate
            return reporting.Print();
        }
    }
}