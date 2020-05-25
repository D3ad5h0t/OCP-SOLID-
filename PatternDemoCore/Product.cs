using System;

namespace PatternDemoCore
{
    public class Product
    {
        public readonly string Name;
        public readonly Color Color;
        public readonly Size Size;

        public Product(string name, Color color, Size size)
        {
            Name = name ?? throw new ArgumentNullException(paramName: nameof(name));
            Color = color;
            Size = size;
        }
    }
}