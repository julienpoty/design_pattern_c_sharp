using Factories;
using Formatters;
using MessageServer;
using Models.Entities;
using Models.Enums;

namespace Bridges;

public class SendNotificationMessageBridge : SendMessageBridge<Notification, NotificationContext>
{
    public SendNotificationMessageBridge(EClientTypeMessage clientMessage,
        NotificationMessageFactory notificationMessageFactory,
        NotificationMessageFormatter notificationFormatter,
        NotificationMessageServer notificationMessageServer
    )
    {
        message = base.GetMessage(notificationMessageFactory, clientMessage);
        messageFormatter = notificationFormatter;
        messageServer = notificationMessageServer;
    }

    public SendNotificationMessageBridge(Notification notificationMessage,
        NotificationMessageFormatter notificationFormatter,
        NotificationMessageServer notificationMessageServer
    )
    {
        message = notificationMessage;
        messageFormatter = notificationFormatter;
        messageServer = notificationMessageServer;
    }
}