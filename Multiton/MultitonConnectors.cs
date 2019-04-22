using System.Collections.Generic;

namespace Multiton
{
    public sealed class MultitonConnectors
    {
        private static readonly IDictionary<ConnectorType, IConnector> staticInstances =
             new Dictionary<ConnectorType, IConnector>();

        public static IConnector GetInstance(ConnectorType connectorType)
        {
            if (!staticInstances.ContainsKey(connectorType))
            {
                staticInstances.Add(connectorType,
                    new FactoryConnection().GetConnector(connectorType));
            }

            return staticInstances[connectorType];
        }
    }
}