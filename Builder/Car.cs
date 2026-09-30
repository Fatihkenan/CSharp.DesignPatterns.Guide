namespace Builder
{
    public class Car
    {
        public Car()
        {
            this.Color = "Red";
            this.EnginePower = 100;
            this.Interior = "Leather";
        }
        public string Color { get; set; }
        public int EnginePower { get; set; }
        public string Interior { get; set; }
    }
}
