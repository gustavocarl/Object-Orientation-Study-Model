namespace Dependency_Inversion_Principle;

public class NotificationService
{
    private readonly ISendMessage _sendMessage;

    public NotificationService(ISendMessage sendMessage)
    {
        _sendMessage = sendMessage;
    }

    public void Notify()
    {
        Console.WriteLine(_sendMessage.SendNotification());
    }
}