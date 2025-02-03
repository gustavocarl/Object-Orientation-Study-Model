namespace Liskov_Substitution_Principle;

public abstract class Vehicle
{
    public string Model { get; set; }

    public string TurnOn()
    {
        return $"O {Model} está ligado";
    }

    public string TurnOff()
    {
        return $"O {Model} está desligado";
    }
}
