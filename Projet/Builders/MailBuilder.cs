using Models.Entities;

namespace Builders;

public class MailBuilder : IMessageBuilder<Mail>
{
    private Mail _message = new();

    public MailBuilder AddAttachment(string attachmentModel)
    {
        return this;
    }

    public MailBuilder SetSender(string sender)
    {
        _message.Sender = sender;
        return this;
    }

    public MailBuilder SetCcs(List<string> ccs)
    {
        _message.Ccs.AddRange(ccs);
        return this;
    }

    public MailBuilder SetBccs(List<string> bccs)
    {
        _message.Bccs.AddRange(bccs);
        return this;
    }

    public MailBuilder SetBodyHtml(string body)
    {
        _message.BodyHtml = body;
        return this;
    }

    public MailBuilder SetSignature(string signature)
    {
        _message.BodyHtml.Replace("$signature", signature);
        return this;
    }

    public MailBuilder SetTitle(string title)
    {
        _message.Title = title;
        return this;
    }

    public Mail Build()
    {
        Mail result = _message;
        _message = new();
        return result;
    }
}