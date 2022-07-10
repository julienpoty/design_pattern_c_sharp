using Models.Entities;

namespace MessageServer;

public class NotificationMessageServer: IMessageServer<Notification>
{
    public void Send(Notification message)
    {
        Console.WriteLine("------------------");
        Console.WriteLine("Send Notification Message");
        Console.WriteLine("---");
        Console.WriteLine("To : " + message.UserTag);
        Console.WriteLine("Message : " + message.Message);
    }
}