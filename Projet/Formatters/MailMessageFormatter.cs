using Models.Entities;

namespace Formatters;

public class MailMessageFormatter : IMessageFormatter<Mail, MailContext> 
{
    public void Format(Mail message, MailContext messageContext)
    {

    }
}