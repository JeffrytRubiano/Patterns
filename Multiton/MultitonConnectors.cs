using System;
using System.Collections;
using System.Collections.Generic;

namespace Multiton
{
    public sealed class MultitonConnectors
    {
        private static readonly IDictionary<Guid, IConnector> staticInstances =
             new Dictionary<Guid, IConnector>();
        private int id;

        private MultitonConnectors()
        {

        }

    }
}