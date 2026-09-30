namespace BuilderDesignPatternExample
{
    public class ProductBuilder
    {
        private readonly Product _product;

        public ProductBuilder()
        {
            _product = new Product();
        }

        public ProductBuilder SetColor(string color)
        {
            _product.Color = color;
            return this;
        }
        public ProductBuilder SetSize(string size)
        {
            _product.Size = size;
            return this;
        }
        public ProductBuilder SetBrand(string brand)
        {
            _product.Brand = brand;
            return this;
        }
        public Product Build()
        {
            return _product;
        }

    }
}
