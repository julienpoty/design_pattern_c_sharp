using Bridges;
using Factories;
using Formatters;
using MessageServer;
using Models.Entities;
using Models.Enums;

internal class Program
{
    private static void Main(string[] args)
    {
        SmsContext context = new()
        {
            Recepients = new() { "06.12.34.56.78" }
        };

        SendSmsMessageBridge bridge = new SendSmsMessageBridge(
            EClientTypeMessage.CancelledOrder,
            new SmsMessageFactory(),
            new SmsMessageFormatter(),
            new SmsMessageServer()
        );

        bridge.Send(context);
    }
}