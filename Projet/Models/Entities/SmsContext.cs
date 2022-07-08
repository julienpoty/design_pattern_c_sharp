using Models.Interfaces;

namespace Models.Entities;

public class SmsContext : IMessageContext
{
    public List<string> Recepients { get; set; }
    public Dictionary<string, string> Data { get; set; }
}