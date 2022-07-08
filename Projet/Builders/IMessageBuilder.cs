using Models.Interfaces;

namespace Builders;

public interface IMessageBuilder<TMessage> where TMessage : IMessage
{
    TMessage Build();
}