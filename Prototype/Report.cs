using System;

namespace Prototype
{
    public abstract class Report
    {
        private readonly string _id;

        public Report()
        {
            _id = Guid.NewGuid().ToString();
        }

        public void Generate()
        {
            // Generate report
        }

        public string GetId() => _id;

        public abstract Report Clone();
    }
}