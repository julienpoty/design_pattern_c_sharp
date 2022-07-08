using Models.Interfaces;

namespace MessageServer;

public interface IMessageServer<TMessage> where TMessage : IMessage
{
    void Send(TMessage message);
}