namespace Commands;

public interface IMessageCommand<TMessage, TMessageContext>
{
    void Execute();
}