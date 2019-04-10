namespace DependencyInjection
{
    public interface IDBConnector
    {
        bool Connect();

        bool Test();
    }
}