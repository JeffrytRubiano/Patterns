namespace Multiton
{
    /// <summary>
    /// Pattern factory method to create instances.
    /// </summary>
    public class FactoryConnection : IFactoryConnection
    {
        public IConnector GetConnector(ConnectorType connectorType)
        {
            IConnector connector;
            switch (connectorType)
            {
                case ConnectorType.Standard:
                    connector = new StandardConnector();
                    break;

                case ConnectorType.Custom:
                    connector = new CustomConnector();
                    break;

                default:
                    throw new System.NotImplementedException();
            }

            return connector;
        }
    }
}