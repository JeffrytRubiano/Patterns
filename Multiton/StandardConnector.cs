using System;

namespace Multiton
{
    public class StandardConnector : IConnector
    {
        private readonly Guid _id;

        public StandardConnector()
        {
            _id = Guid.NewGuid();
        }

        public bool Connect()
        {
            return true;
        }

        public Guid GetObjectId()
        {
            return _id;
        }
    }
}