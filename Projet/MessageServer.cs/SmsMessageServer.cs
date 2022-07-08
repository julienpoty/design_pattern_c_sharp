using Models.Entities;
using Models.Interfaces;

namespace MessageServer;

public class SmsMessageServer : IMessageServer<Sms>
{
    public void Send(Sms message)
    {
        
    }
}