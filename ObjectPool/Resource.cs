using System;

namespace ObjectPool
{
    public class Resource
    {
        private readonly string _id;

        public Resource()
        {
            _id = Guid.NewGuid().ToString();
        }

        public string GetId()
        {
            return _id;
        }
    }
}