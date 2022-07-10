using Models.Interfaces;

namespace Models.Entities;

public class Mail : IMessage
{
    public string Sender { get; set; }
    public List<string> Recepients { get; set; } = new();
    public List<string> Ccs { get; set; } = new();
    public List<string> Bccs { get; set; } = new();
    public string Title {get; set;}
    public string BodyHtml { get; set; }
    public string BodyText { get; set; }

    public IMessage DeepCopy()
    {
        Mail newMail = (Mail) this.MemberwiseClone();
        newMail.Recepients = new();
        newMail.Recepients.AddRange(this.Recepients);
        newMail.Ccs = new();
        newMail.Ccs.AddRange(this.Ccs);
        newMail.Bccs = new();
        newMail.Bccs.AddRange(this.Bccs);

        return newMail;
    }
}

