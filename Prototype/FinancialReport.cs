namespace Prototype
{
    public class FinancialReport : Report
    {
        public override Report Clone()
        {
            return (Report)MemberwiseClone();
        }
    }
}