using Models.Interfaces;

namespace Models.Entities;

public class Mail : IMessage
{
    public string Sender { get; set; }
    public List<string> Recepients { get; set; }
    public List<string> Ccs { get; set; }
    public List<string> Bccs { get; set; }
    public string Title {get; set;}
    public string BodyHtml { get; set; }
    public string BodyText { get; set; }
}

