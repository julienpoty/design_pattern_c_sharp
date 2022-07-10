using Models.Entities;

namespace MessageServer;

public class SmsMessageServer : IMessageServer<Sms>
{
    public void Send(Sms message)
    {
        Console.WriteLine("------------------");
        Console.WriteLine("Send Sms Message");
        Console.WriteLine("---");
        Console.WriteLine("To : " + message.Recepient);
        Console.WriteLine("Message : " + message.Content);
        if(string.IsNullOrWhiteSpace(message.MediaURL) == false)
        {
            Console.WriteLine("MediaURL : " + message.MediaURL);
        }
    }
}