using System;
using System.Collections.Concurrent;

namespace ObjectPool
{
    public class Pool<T> where T : class
    {
        private readonly Func<T> _generator;
        private readonly ConcurrentBag<T> _pool;

        // Inject the behavior to create the object.
        public Pool(Func<T> delegateGenerator)
        {
            _pool = new ConcurrentBag<T>();
            _generator = delegateGenerator;
        }

        public T Get()
        {
            if (_pool.TryTake(out T item)) return item;

            return _generator();
        }

        public void PutBack(T obj)
        {
            _pool.Add(obj);
        }
    }
}