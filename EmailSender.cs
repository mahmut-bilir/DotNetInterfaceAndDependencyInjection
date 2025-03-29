public class EmailSender : IMessageSender
{

    public void Send(string message)
    {
        Console.WriteLine("Email Sent:" + message);
    }
}