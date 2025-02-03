using ObjectOrientationProject;

namespace Object_Orientation_Project;

public class Car : Vehicle
{
    public Car(string model, int year, int numberOfDoors) : base(model, year)
    {
        NumberOfDoors = numberOfDoors;
    }

    public int NumberOfDoors { get; set; }

    public override void Move()
    {
        Console.WriteLine($"O carro {Model} está se movendo pela estrada");
    }
}