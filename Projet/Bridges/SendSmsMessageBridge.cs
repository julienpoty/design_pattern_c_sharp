using Factories;
using Formatters;
using MessageServer;
using Models.Entities;
using Models.Enums;

namespace Bridges;

public class SendSmsMessageBridge : SendMessageBridge<Sms, SmsContext>
{
    public SendSmsMessageBridge(EClientTypeMessage clientMessage,
        SmsMessageFactory smsMessageFactory,
        SmsMessageFormatter smsFormatter,
        SmsMessageServer smsMessageServer
    )
    {
        message = base.GetMessage(smsMessageFactory, clientMessage);
        messageFormatter = smsFormatter;
        messageServer = smsMessageServer;
    }

    public SendSmsMessageBridge(Sms smsMessage,
        SmsMessageFormatter smsFormatter,
        SmsMessageServer smsMessageServer
    )
    {
        message = smsMessage;
        messageFormatter = smsFormatter;
        messageServer = smsMessageServer;
    }
}