using Bridges;
using Models.Entities;

namespace Commands;

public class NotificationMessageCommand : MessageCommand<Notification, NotificationContext>
{
    public NotificationMessageCommand(NotificationContext notificationContext, SendNotificationMessageBridge sendNotificationMessageBridge)
    {
        messageContext = notificationContext;
        sendMessageBridge = sendNotificationMessageBridge;
    }
}