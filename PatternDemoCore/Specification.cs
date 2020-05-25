using System.Linq;

namespace PatternDemoCore
{
    public abstract class Specification<T>
    {
        public abstract bool IsSatisfield(T p);

        public static Specification<T> operator &(Specification<T> first, Specification<T> second)
        {
            return new AndSpecification<T>(first, second);
        }
    }
    
    public abstract class CompositeSpecification<T> : Specification<T>
    {
        protected readonly Specification<T>[] items;

        public CompositeSpecification(params Specification<T>[] items)
        {
            this.items = items;
        }
    }
    
    
    public class AndSpecification<T> : CompositeSpecification<T>
    {
        public AndSpecification(params Specification<T>[] items) : base(items)
        {
            
        }

        public override bool IsSatisfield(T p)
        {
            return items.All(i => i.IsSatisfield(p));
        }
    }

}