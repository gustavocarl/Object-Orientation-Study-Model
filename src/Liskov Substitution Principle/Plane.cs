namespace Liskov_Substitution_Principle;

public class Plane : Vehicle, IFly
{
    public string Fly()
    {
        return $"O {Model} está voando";
    }
}