using System.Text;
using Models.Entities;

namespace Formatters;

public class MailMessageFormatter : IMessageFormatter<Mail, MailContext> 
{
    public void Format(Mail message, MailContext messageContext)
    {
        message.Recepients.AddRange(messageContext.Recepients);
        StringBuilder sb = new StringBuilder(message.BodyText);

        foreach(var value in messageContext.Data)
        {            
            sb.Replace("$"+value.Key, value.Value);            
        }
        
        message.BodyText = sb.ToString();
    }
}