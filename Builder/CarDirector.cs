namespace Builder
{
    public class CarDirector
    {
        public Car BuildSportCar()
        {
            return new CarBuilder()
                .WithColor("Blue")
                .WithEnginePower(400)
                .WithInterior("süet")
                .Build();
        }
        public Car BuildFamilyCar()
        {
            return new CarBuilder()
                .WithColor("yellow")
                .Build();
        }
    }
}
