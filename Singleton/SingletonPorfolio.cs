using System;

namespace Singleton
{
    // Singleton with Full lazy instantiation.
    public sealed class SingletonPorfolio
    {
        // Thread-safe
        private static readonly Lazy<Portfolio> single =
            new Lazy<Portfolio>(() => new Portfolio());

        public static Portfolio Instance
        {
            get
            {
                return single.Value;
            }
        }

        private SingletonPorfolio()
        { 
            // Explicit constructor.
        }
    }
}