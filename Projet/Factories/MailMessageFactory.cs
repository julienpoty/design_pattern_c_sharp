using Builders;
using Models.Interfaces;

namespace Factories;

public class MailMessageFactory : IAbstractMessageFactory
{
    MailBuilder builder = new();

    public IMessage CreateOrderConfirmationMessage => builder
            .SetTitle("Confirmation de votre commande")
            .SetSender("customer-service@shop.com")
            .SetBccs(new List<string> { "order-preparation@shop.com" })
            .SetBodyText("Bonjour, Nous vous confirmons la validation de votre command n°$CommandId.")
            .AddAttachment("PurchaseOrder")
            .Build();

    public IMessage CreateShippedOrderMessage => builder
            .SetTitle("Commande expédié")
            .SetSender("shipping@shop.com")
            .SetBccs(new List<string> { "customer-service@shop.com" })
            .SetBodyText("Bonjour, Nous vous confirmons l'expédition' de votre command n°$CommandId.")
            .Build();

    public IMessage CreateCancelledOrderMEssage => builder
            .SetSender("customer-service@shop.com")
            .SetTitle("Votre commande a été annulé")
            .SetBccs(new List<string> { "order-preparation@shop.com" })
            .SetBodyText("Bonjour, Nous vous confirmons l'annulation' de votre command n°$CommandId.")
            .Build();

    public IMessage CreatePromoCodeMessage => builder
            .SetTitle("Nouveau code promo")
            .SetSender("promo@shop.com")
            .SetBodyText("Bonjour, Profitez de 10€ de réduction avec le code $PromoCode.")
            .Build();
}