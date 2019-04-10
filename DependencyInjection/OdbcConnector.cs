namespace DependencyInjection
{
    public class OdbcConnector : IDBConnector
    {
        public bool Connect()
        {
            return true;
        }

        public bool Test()
        {
            return true;
        }
    }
}