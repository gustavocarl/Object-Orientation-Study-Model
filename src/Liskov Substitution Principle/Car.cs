namespace Liskov_Substitution_Principle;

public class Car : Vehicle, IRun
{

    public string Run()
    {
        return $"O {Model} está correndo";
    }
}