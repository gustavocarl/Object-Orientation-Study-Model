namespace ObjectOrientationProject;

public abstract class Vehicle
{
    public Vehicle(string model, int year)
    {
        Model = model;
        Year = year;
    }

    public string Model { get; set; }

    public int Year { get; set; }

    public void Start()
    {
        Console.WriteLine($"Ligando o {Model}");
    }

    public void Stop()
    {
        Console.WriteLine($"Desligando o {Model}");
    }

    public abstract void Move();
}