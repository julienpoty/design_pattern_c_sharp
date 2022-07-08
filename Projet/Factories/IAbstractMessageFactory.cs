using Models.Interfaces;

namespace Factories;

public interface IAbstractMessageFactory
{
    IMessage CreateOrderConfirmationMessage { get; }
    IMessage CreateShippedOrderMessage { get; }
    IMessage CreateCancelledOrderMEssage { get; }
    IMessage CreatePromoCodeMessage { get; }
}