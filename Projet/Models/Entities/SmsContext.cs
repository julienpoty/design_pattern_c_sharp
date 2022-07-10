using Models.Interfaces;

namespace Models.Entities;

public class SmsContext : IMessageContext<Sms>
{
    public string Recepient { get; set; }
    public Dictionary<string, string> Data { get; set; } = new();
}