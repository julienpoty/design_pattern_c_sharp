using Models.Entities;

namespace MessageServer;

public class MailMessageServer : IMessageServer<Mail>
{
    public void Send(Mail message)
    {
        Console.WriteLine("------------------");
        Console.WriteLine("Send Mail Message");
        Console.WriteLine("---");
        Console.WriteLine("To : " + string.Join(", ", message.Recepients));        
        Console.WriteLine("Title : " + message.Title);        
        Console.WriteLine("Message : " + message.BodyText);
    }
}