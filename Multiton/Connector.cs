using System;

namespace Multiton
{
    public interface IConnector
    {
        bool Connect();
        Guid GetObjectId();
    }
}