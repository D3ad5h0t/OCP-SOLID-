using System.Collections.Generic;

namespace PatternDemoCore
{
    public class BetterFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, Specification<Product> spec)
        {
            foreach (var item in items)
            {
                if (spec.IsSatisfield(item)) yield return item;
            }
        }
    }
}