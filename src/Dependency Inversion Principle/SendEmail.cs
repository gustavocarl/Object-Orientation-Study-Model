namespace Dependency_Inversion_Principle;

public class SendEmail : ISendMessage
{
    public string Email { get; set; }

    public string SendNotification()
    {
        return $"Enviando Email para {Email}";
    }
}