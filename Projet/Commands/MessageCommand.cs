using Bridges;
using Models.Interfaces;

namespace Commands;

public abstract class MessageCommand<TMessage, TMessageContext> : IMessageCommand<IMessage, IMessageContext<IMessage>>
 where TMessage : IMessage
 where TMessageContext : IMessageContext<TMessage>
{
    protected SendMessageBridge<TMessage , TMessageContext> sendMessageBridge;
    protected TMessageContext messageContext;

    public void Execute()
    {
        sendMessageBridge.Send(messageContext);
    }
}