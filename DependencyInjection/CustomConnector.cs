namespace DependencyInjection
{
    public class CustomConnector : IDBConnector
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