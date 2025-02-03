using ObjectOrientationProject;

namespace Object_Orientation_Project;

public class Plane : Vehicle
{
    public Plane(string model, int year, int numberOfEngines) : base(model, year)
    {
        NumberOfEngines = numberOfEngines;
    }

    public int NumberOfEngines { get; set; }

    public override void Move()
    {
        Console.WriteLine($"O avião {Model} está voando!");
    }
}