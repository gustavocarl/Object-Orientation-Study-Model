namespace Open_Closed_Principle;

public class PaymentProcessor
{
    public string ProcessPayment(IPaymentMethod _paymentMethod)
    {
        return $"Pagamento realizado com: {_paymentMethod.ProcessPayment()}";
    }
}