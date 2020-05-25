using System.Collections.Generic;

namespace PatternDemoCore
{
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, Specification<T> spec);
    }
}