namespace BuilderDesignPatternExample
{
    public class ProductDirector
    {
        public Product BuildProduct(string color, string size, string brand)
        {
            return new ProductBuilder()
                .SetColor(color)
                .SetSize(size)
                .SetBrand(brand)
                .Build();
        }
    }
}
