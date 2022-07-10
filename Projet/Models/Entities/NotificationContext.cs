using Models.Interfaces;

namespace Models.Entities;

public class NotificationContext : IMessageContext<Notification>
{
    public string UserTag { get; set; }
}