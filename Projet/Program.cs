using Bridges;
using Commands;
using Facade;
using Factories;
using Formatters;
using MessageServer;
using Models.Entities;
using Models.Enums;
using Models.Interfaces;

internal class Program
{
    private static void Main(string[] args)
    {

        SendSmsMessageBridge bridge = new SendSmsMessageBridge(
            EClientTypeMessage.CancelledOrder,
            new SmsMessageFactory(),
            new SmsMessageFormatter(),
            new SmsMessageServer()
        );

        ClientMessageContext clientMessageContext = new()
        {
            Email = "jean@test.fr",
            PhoneNumber = "06.12.34.56.78",
            UserTag = "jean",
            Preferences = new()
            {
                AcceptEmail = true,
                AcceptSms = true,
                AcceptNotification = true
            },
            Data = new()
            {
                { "CommandId", "044674" },
            }
        };
        ClientMessageContext clientMessageContext2 = new()
        {
            Email = "marie@test.fr",
            PhoneNumber = "06.45.23.11.22",
            UserTag = "marie",
            Preferences = new()
            {
                AcceptEmail = true,
                AcceptSms = false,
                AcceptNotification = false
            },
            Data = new()
            {
                { "CommandId", "044326" },
            }
        };
        ClientMessageContext clientMessageContext3 = new()
        {
            Email = "pierre@test.fr",
            PhoneNumber = "06.89.23.44.83",
            UserTag = "pierre",
            Preferences = new()
            {
                AcceptEmail = false,
                AcceptSms = true,
                AcceptNotification = false
            },
            Data = new()
            {
                { "CommandId", "048906" },
            }
        };

        List<ClientMessageContext> clientMessageContexts = new ()
        {
            clientMessageContext,
            clientMessageContext2,
            clientMessageContext3
        };

        CommandFacade facade = new();

        List<IMessageCommand<IMessage, IMessageContext<IMessage>>> commandList = facade.CreateMessageCommands(EClientTypeMessage.CancelledOrder, clientMessageContexts);
        
        foreach(var command in commandList)
        {
            command.Execute();
        }
    }
}