using System;

namespace Multiton
{
    public class CustomConnector : IConnector
    {
        private readonly Guid _id;

        public CustomConnector()
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