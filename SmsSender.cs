public class SmsSender : IMessageSender
{
    public void Send(string message)
    {
        Console.WriteLine("Sms sent: " + message);
    }
}