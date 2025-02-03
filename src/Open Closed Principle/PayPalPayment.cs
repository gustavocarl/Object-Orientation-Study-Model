namespace Open_Closed_Principle;

public class PayPalPayment : IPaymentMethod
{
    public string ProcessPayment()
    {
        return "Paypal";
    }
}