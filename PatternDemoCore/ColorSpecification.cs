namespace PatternDemoCore
{
    public class ColorSpecification : Specification<Product>
    {
        private Color color;

        public ColorSpecification(Color color)
        {
            this.color = color;
        }

        public override bool IsSatisfield(Product p) => p.Color == color;
    }
}