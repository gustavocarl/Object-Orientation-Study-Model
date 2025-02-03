namespace Liskov_Substitution_Principle;

public class Boat : Vehicle, ISwin
{
    public string Swin()
    {
        return $"O {Model} está navegando";
    }
}