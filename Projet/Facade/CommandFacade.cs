using Bridges;
using Commands;
using Factories;
using Formatters;
using MessageServer;
using Models.Entities;
using Models.Enums;
using Models.Interfaces;

namespace Facade;

public class CommandFacade
{
    public List<IMessageCommand<IMessage, IMessageContext<IMessage>>> CreateMessageCommands(EClientTypeMessage clientTypeMessage, ClientMessageContext clientMessageContext)
    {    
        List<IMessageCommand<IMessage, IMessageContext<IMessage>>> commandList = new();

        if(clientMessageContext.Preferences.AcceptEmail)
        {
            commandList.Add(new MailMessageCommand(new () {
                Recepients = new() { clientMessageContext.Email, },
                Data = clientMessageContext.Data
            }, new(clientTypeMessage, new MailMessageFactory(), new MailMessageFormatter(), new MailMessageServer())));
        }
        if(clientMessageContext.Preferences.AcceptSms)
        {
            commandList.Add(new SmsMessageCommand(new () {
                    Recepient = clientMessageContext.PhoneNumber,
                    Data = clientMessageContext.Data
                }, new(clientTypeMessage, new SmsMessageFactory(), new SmsMessageFormatter(), new SmsMessageServer())));
        }
        if(clientMessageContext.Preferences.AcceptNotification)
        {
            commandList.Add(new NotificationMessageCommand(new () {
                    UserTag = clientMessageContext.UserTag
                }, new(clientTypeMessage, new NotificationMessageFactory(), new NotificationMessageFormatter(), new NotificationMessageServer())));
        }

        return commandList;
    }

    public List<IMessageCommand<IMessage, IMessageContext<IMessage>>>CreateMessageCommands(EClientTypeMessage clientTypeMessage, List<ClientMessageContext> clientMessageContextList)
    {
        SendMailMessageBridge sendMailMessageBridge = new(clientTypeMessage, new MailMessageFactory(), new MailMessageFormatter(), new MailMessageServer());
        SendSmsMessageBridge sendSmsMessageBridge = new(clientTypeMessage, new SmsMessageFactory(), new SmsMessageFormatter(), new SmsMessageServer());
        SendNotificationMessageBridge sendNotificationMessageBridge = new(clientTypeMessage, new NotificationMessageFactory(), new NotificationMessageFormatter(), new NotificationMessageServer());

        List<IMessageCommand<IMessage, IMessageContext<IMessage>>> commandList = new();

        foreach(ClientMessageContext clientMessageContext in clientMessageContextList)
        {
            if(clientMessageContext.Preferences.AcceptEmail)
            {
                commandList.Add(new MailMessageCommand(new () {
                    Recepients = new() { clientMessageContext.Email, },
                    Data = clientMessageContext.Data
                }, sendMailMessageBridge));
            }
            if(clientMessageContext.Preferences.AcceptSms)
            {
                commandList.Add(new SmsMessageCommand(new () {
                    Recepient = clientMessageContext.PhoneNumber,
                    Data = clientMessageContext.Data
                }, sendSmsMessageBridge));
            }
            if(clientMessageContext.Preferences.AcceptNotification)
            {
                commandList.Add(new NotificationMessageCommand(new () {
                    UserTag = clientMessageContext.UserTag
                }, sendNotificationMessageBridge));
            }
        }

        return commandList;
    }
}