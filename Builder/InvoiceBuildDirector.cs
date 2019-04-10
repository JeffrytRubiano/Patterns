namespace Builder
{
    public class InvoiceBuildDirector
    {
        private readonly IInvoiceBuilder _builder;

        public InvoiceBuildDirector(IInvoiceBuilder builder)
        {
            _builder = builder;
        }

        public Invoice Build() => _builder.GetInvoice();
    }
}