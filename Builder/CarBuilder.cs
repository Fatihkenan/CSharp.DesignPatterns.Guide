namespace Builder
{
    public class CarBuilder
    {
        private readonly Car _car;

        public CarBuilder()
        {
            _car = new Car();
        }

        public CarBuilder WithColor(string color)
        {
            _car.Color = color;
            return this;
        }

        public CarBuilder WithEnginePower(int enginePower)
        {
            _car.EnginePower = enginePower;
            return this;
        }

        public CarBuilder WithInterior(string interior)
        {
            _car.Interior = interior;
            return this;
        }

        public Car Build()
        {
            return _car;
        }
    }
}
