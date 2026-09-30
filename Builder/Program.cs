using Builder;

Car car = new CarDirector().BuildSportCar();
Console.WriteLine($"sport car: Color= {car.Color} , EnginePower={car.EnginePower}, Interior={car.Interior}");

Car familyCar = new CarDirector().BuildFamilyCar();
Console.WriteLine($"Family Car: Color= {familyCar.Color} , EnginePower={familyCar.EnginePower}, Interior={familyCar.Interior}sdfsg");
Console.ReadLine();
