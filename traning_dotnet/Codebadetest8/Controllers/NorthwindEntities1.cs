using System.Collections.Generic;

namespace CodeBasedTestMVC
{
    internal class NorthwindEntities
    {
        internal IEnumerable<object> customers;

        public object Customers { get; internal set; }
        public object Orders { get; internal set; }
    }
}