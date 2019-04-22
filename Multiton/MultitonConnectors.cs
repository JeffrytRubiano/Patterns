using System.Collections.Generic;

namespace Multiton
{
    /// <summary>
    /// In this class, we can see how the pattern is applied.
    /// </summary>
    public sealed class MultitonConnectors
    {
        // Objet to storage the instances.
        private static readonly IDictionary<ConnectorType, IConnector> staticInstances =
             new Dictionary<ConnectorType, IConnector>();

        public static IConnector GetInstance(ConnectorType connectorType)
        {
            // Validate if the object is already created.
            if (!staticInstances.ContainsKey(connectorType))
            {
                // Call a factory to create the instance.
                staticInstances.Add(connectorType,
                    new FactoryConnection().GetConnector(connectorType));
            }

            return staticInstances[connectorType];
        }
    }
}