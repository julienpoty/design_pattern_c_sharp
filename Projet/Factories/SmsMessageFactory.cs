using Builders;
using Models.Interfaces;

namespace Factories;

public class SmsMessageFactory : IAbstractMessageFactory
{
    SmsBuilder builder = new();

    public IMessage CreateOrderConfirmationMessage => builder
            .SetMessage("Nous vous confirmons votre commande n°$CommandId.")
            .SetMediaURL("https:://www.shop.com/order/$OrderId")
            .Build();

    public IMessage CreateShippedOrderMessage => builder
            .SetMessage("Expédition de votre commande n°$CommandId.")
            .Build();

    public IMessage CreateCancelledOrderMEssage => builder
            .SetMessage("Annulation de votre commande n°$CommandId.")
            .Build();

    public IMessage CreatePromoCodeMessage => builder
            .SetMessage("Profitez de $montant euros de réduction avec le code $PromoCode.")
            .Build();
}