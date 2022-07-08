using Factories;
using Formatters;
using MessageServer;
using Models.Enums;
using Models.Interfaces;

namespace Bridges;

public abstract class SendMessageBridge<TMessage, TMessageContext> 
    where TMessage : IMessage 
    where TMessageContext : IMessageContext
{
    protected TMessage message;
    protected IMessageFormatter<TMessage, TMessageContext> messageFormatter;
    protected IMessageServer<TMessage> messageServer;

    public void Send(TMessageContext messageContext)
    {
        messageFormatter.Format(message, messageContext);

        messageServer.Send(message);
    }

    protected TMessage GetMessage(IAbstractMessageFactory messageFactory, EClientTypeMessage messageClient)
    {
        return messageClient switch
        {
            EClientTypeMessage.OrderConfirmation => (TMessage)messageFactory.CreateOrderConfirmationMessage,
            EClientTypeMessage.ShippedOrder => (TMessage)messageFactory.CreateShippedOrderMessage,
            EClientTypeMessage.CancelledOrder => (TMessage)messageFactory.CreateCancelledOrderMEssage,
            EClientTypeMessage.PromoCode => (TMessage)messageFactory.CreatePromoCodeMessage
        };
    }
}