namespace PatternDemoCore
{
    public class SizeSpecification : Specification<Product>
    {
        private Size size;

        public SizeSpecification(Size size)
        {
            this.size = size;
        }


        public override bool IsSatisfield(Product p) => p.Size == size;
    }
}