using Models.Entities;

namespace Formatters;

public class NotificationMessageFormatter : IMessageFormatter<Notification, NotificationContext> 
{
    public void Format(Notification message, NotificationContext messageContext)
    {
        message.UserTag = messageContext.UserTag;
    }
}