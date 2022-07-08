using Models.Entities;
using Models.Interfaces;

namespace Factories;

public class NotificationMessageFactory : IAbstractMessageFactory
{

    public IMessage CreateOrderConfirmationMessage => new Notification()
    {
        Message = "Confirmation de votre commande."
    };

    public IMessage CreateShippedOrderMessage => new Notification()
    {
        Message = "Votre commande a été expédié."
    };

    public IMessage CreateCancelledOrderMEssage => new Notification()
    {
        Message = "Annulation de votre commande."
    };

    public IMessage CreatePromoCodeMessage => new Notification()
    {
        Message = "Nouveau code promo !"
    };
}