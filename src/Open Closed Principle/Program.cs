using Open_Closed_Principle;

PaymentProcessor processor = new PaymentProcessor();

IPaymentMethod creditCard = new CreditCardPayment();
IPaymentMethod pix = new PixPayment();
IPaymentMethod paypal = new PayPalPayment();

Console.WriteLine(processor.ProcessPayment(creditCard));
Console.WriteLine(processor.ProcessPayment(pix));
Console.WriteLine(processor.ProcessPayment(paypal));