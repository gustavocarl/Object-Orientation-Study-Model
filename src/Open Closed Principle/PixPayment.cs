namespace Open_Closed_Principle;

public class PixPayment : IPaymentMethod
{
    public string ProcessPayment()
    {
        return "Pix";
    }
}