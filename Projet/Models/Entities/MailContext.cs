using Models.Interfaces;

namespace Models.Entities;

public class MailContext : IMessageContext
{
    public List<string> Recepients { get; set; }
    public List<string> Ccs { get; set; }
    public List<string> Bccs { get; set; }
    public Dictionary<string, string> Data { get; set; }
}
