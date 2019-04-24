namespace Prototype
{
    public class LogisticReport : Report
    {
        public override Report Clone()
        {
            return (Report)MemberwiseClone();
        }
    }
}