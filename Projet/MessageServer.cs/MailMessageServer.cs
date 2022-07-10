using Models.Entities;

namespace MessageServer;

public class MailMessageServer : IMessageServer<Mail>
{
    public void Send(Mail message)
    {
        Console.WriteLine("------------------");
        Console.WriteLine("Send Mail Message");
        Console.WriteLine("---");
        Console.WriteLine("From : " + message.Sender);
        Console.WriteLine("To : " + string.Join(", ", message.Recepients));
        if(message.Ccs.Count > 0)
        {
            Console.WriteLine("Cc : " + string.Join(", ", message.Ccs));
        }
        if(message.Bccs.Count > 0)
        {
            Console.WriteLine("Cc : " + string.Join(", ", message.Bccs));
        }
        Console.WriteLine("Title : " + message.Title);        
        Console.WriteLine("Message : " + message.BodyText);
    }
}