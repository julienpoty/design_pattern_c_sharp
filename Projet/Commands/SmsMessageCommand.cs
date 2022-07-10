using Bridges;
using Models.Entities;

namespace Commands;

public class SmsMessageCommand : MessageCommand<Sms, SmsContext>
{
    public SmsMessageCommand(SmsContext smsContext, SendSmsMessageBridge sendSmsMessageBridge)
    {
        messageContext = smsContext;
        sendMessageBridge = sendSmsMessageBridge;
    }

}