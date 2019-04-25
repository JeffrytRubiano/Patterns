using System;

namespace Singleton
{
    public class Portfolio
    {
        private readonly string _id;

        public Portfolio()
        {
            _id = Guid.NewGuid().ToString();
        }

        public bool Exist()
        {
            return true;
        }

        public string GetId() => _id;
    }
}