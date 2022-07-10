using Models.Interfaces;

namespace Models.Entities;

public class MailContext : IMessageContext<Mail>
{
    public List<string> Recepients { get; set; } = new();
    public List<string> Ccs { get; set; } = new();
    public List<string> Bccs { get; set; } = new();
    public Dictionary<string, string> Data { get; set; } = new();
}
