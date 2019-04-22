namespace Multiton
{
    public interface IFactoryConnection
    {
        IConnector GetConnector(ConnectorType connectorType);
    }
}