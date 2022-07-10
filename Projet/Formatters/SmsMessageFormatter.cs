using System.Text;
using Models.Entities;

namespace Formatters;

public class SmsMessageFormatter : IMessageFormatter<Sms, SmsContext> 
{
    public void Format(Sms message, SmsContext messageContext)
    {
        message.Recepient = messageContext.Recepient;        
        StringBuilder sb = new StringBuilder(message.Content);

        foreach(var value in messageContext.Data)
        {
            sb.Replace("$"+value.Key, value.Value);
        }

        message.Content = sb.ToString();
    }
}