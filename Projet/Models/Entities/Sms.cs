using Models.Interfaces;

namespace Models.Entities;

public class Sms : IMessage
{
    public string Sender { get; set; }
    public string Recepient { get; set; }
    public string MediaURL { get; set; }
    public string Content { get; set; }
}