namespace BuilderDesignPatternExample
{
    public class Product
    {
        public Product()
        {
            this.Color = "red";
            this.Size = "M";
            this.Brand = "Nike";
        }
        public string Color { get; set; }
        public string Size { get; set; }
        public string Brand { get; set; }
    }
}
