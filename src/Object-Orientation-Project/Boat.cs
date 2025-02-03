using ObjectOrientationProject;

namespace Object_Orientation_Project;

public class Boat : Vehicle
{
    public Boat(string model, int year, bool hasSails) : base(model, year)
    {
        HasSails = hasSails;
    }

    public bool HasSails { get; set; }

    public override void Move()
    {
        Console.WriteLine($"O bardo {Model} está navegando pelos mares");
    }
}