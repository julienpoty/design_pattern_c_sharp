using Bridges;
using Models.Entities;

namespace Commands;

public class MailMessageCommand : MessageCommand<Mail, MailContext>
{
    public MailMessageCommand(MailContext mailContext, SendMailMessageBridge sendMailMessageBridge)
    {
        messageContext = mailContext;
        sendMessageBridge = sendMailMessageBridge;
    }
}