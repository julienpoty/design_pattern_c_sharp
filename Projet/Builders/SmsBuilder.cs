using Models.Entities;

namespace Builders;

public class SmsBuilder : IMessageBuilder<Sms>
{
    private Sms _message = new();

    public SmsBuilder SetSender(string sender)
    {
        _message.Sender = sender;
        return this;
    }

    public SmsBuilder SetMessage(string message)
    {
        _message.Content = message;
        return this;
    }

    public SmsBuilder SetMediaURL(string mediaURL)
    {
        _message.MediaURL = mediaURL;
        return this;
    }

    public Sms Build()
    {
        Sms result = _message;
        _message = new();
        return result;
    }
}