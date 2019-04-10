namespace DependencyInjection
{
    public class Connection
    {
        private readonly IDBConnector dBConnector;

        public Connection(IDBConnector dBConnector)
        {
            this.dBConnector = dBConnector;
        }

        public bool TestConnection()
        {
            return dBConnector.Connect();
        }
    }
}