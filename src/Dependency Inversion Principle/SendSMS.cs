namespace Dependency_Inversion_Principle;

public class SendSMS : ISendMessage
{
    public string PhoneNumber { get; set; }

    public string SendNotification()
    {
        return $"Enviando SMS para o número {PhoneNumber}";
    }
}