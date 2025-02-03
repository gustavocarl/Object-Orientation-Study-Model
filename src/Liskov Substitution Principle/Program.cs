using Liskov_Substitution_Principle;

Car car = new()
{
    Model = "Fiesta",
};

Console.WriteLine(car.TurnOn());
Console.WriteLine(car.Run());
Console.WriteLine(car.TurnOff());


Console.WriteLine("\n");

Boat boat = new()
{
    Model = "Barco",
};

Console.WriteLine(boat.TurnOn());
Console.WriteLine(boat.Swin());
Console.WriteLine(boat.TurnOff());

Console.WriteLine("\n");

Plane plane = new()
{
    Model = "Boeing 747",
};

Console.WriteLine(plane.TurnOn());
Console.WriteLine(plane.Fly());
Console.WriteLine(plane.TurnOff());

