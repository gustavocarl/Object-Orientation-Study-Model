namespace Open_Closed_Principle;

public class CreditCardPayment : IPaymentMethod
{
    public string ProcessPayment()
    {
        return "Cartão de Crédito";
    }
}