using System.Collections.Concurrent;

namespace ObjectPool
{
    public class Pool<T> where T : new()
    {
        private readonly ConcurrentBag<T> rooms = new ConcurrentBag<T>();
        private int counter = 0;
        private readonly int max = 10;

        public void PutBack(T obj)
        {
            if (counter < max)
            {
                rooms.Add(obj);
                counter++;
            }
        }

        public T Get()
        {
            if (rooms.TryTake(out T obj))
            {
                counter--;
                return obj;
            }
            else
            {
                T newObj = new T();
                rooms.Add(newObj);
                counter++;
                return newObj;
            }
        }
    }
}