using System;

namespace Builder
{
    public class Invoice
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public double Value { get; set; }
        public string  Adress { get; set; }

        public Invoice(Guid id, DateTime date, double value, string adress)
        {
            Id = id;
            Date = date;
            Value = value;
            Adress = adress;
        }
    }
}