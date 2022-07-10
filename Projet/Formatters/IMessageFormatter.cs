using Models.Interfaces;

namespace Formatters;

public interface IMessageFormatter<TMessage, TMessageContext> 
    where TMessage : IMessage
    where TMessageContext : IMessageContext<TMessage>
{
    void Format(TMessage message, TMessageContext messageContext);
}