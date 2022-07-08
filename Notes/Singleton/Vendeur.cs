
public class Vendeur
{
    static Vendeur vendeur;
    public static Vendeur Instance()
    {
        if(vendeur is null)
        {
            vendeur = new Vendeur();
        }
        return vendeur;
    }
}