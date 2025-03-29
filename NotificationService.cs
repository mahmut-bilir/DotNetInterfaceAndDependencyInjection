public class NotificationService
{
    private readonly IMessageSender _messageSender;
    public NotificationService(IMessageSender messageSender)
    {
        _messageSender = messageSender;
    }

    public void NotificationSender(string message)
    {
        _messageSender.Send(message);
    }


}