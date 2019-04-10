using System;

namespace Builder
{
    public class DefaultBranchInvoiceBuilder : IInvoiceBuilder
    {
        public Invoice GetInvoice()
        {
            return new Invoice(GenerateId(), GetDateTime(), GetTotal(), GetAdressForPrint());
        }

        private Guid GenerateId()
        {
            return Guid.NewGuid();
        }

        private string GetAdressForPrint()
        {
            return Guid.NewGuid().ToString();
        }

        private DateTime GetDateTime()
        {
            return DateTime.Now;
        }

        private double GetTotal()
        {
            return new Random().NextDouble() * 10000;
        }
    }
}