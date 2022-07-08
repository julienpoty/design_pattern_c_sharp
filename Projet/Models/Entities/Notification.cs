using Models.Interfaces;

namespace Models.Entities;

public class Notification : IMessage
{
    public string UserTag { get; set; }
    public string Message { get; set; }
}
