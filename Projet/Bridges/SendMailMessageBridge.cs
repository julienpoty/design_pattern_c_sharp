using Factories;
using Formatters;
using MessageServer;
using Models.Entities;
using Models.Enums;

namespace Bridges;

public class SendMailMessageBridge : SendMessageBridge<Mail, MailContext>
{
    public SendMailMessageBridge(EClientTypeMessage clientMessage,
        MailMessageFactory mailMessageFactory,
        MailMessageFormatter mailFormatter,
        MailMessageServer mailMessageServer
    )
    {
        message = base.GetMessage(mailMessageFactory, clientMessage);
        messageFormatter = mailFormatter;
        messageServer = mailMessageServer;
    }

    public SendMailMessageBridge(Mail mailMessage,
        MailMessageFormatter mailFormatter,
        MailMessageServer mailMessageServer
    )
    {
        message = mailMessage;
        messageFormatter = mailFormatter;
        messageServer = mailMessageServer;
    }
}