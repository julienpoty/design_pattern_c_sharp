using Models.Entities;

namespace Formatters;

public class SmsMessageFormatter : IMessageFormatter<Sms, SmsContext> 
{
    public void Format(Sms message, SmsContext messageContext)
    {

    }
}