namespace AbstractFactory;

public class AutomobileElectrique : Automobile
{
    public AutomobileElectrique(string modele, string couleur, int puissance, double espace) : base (modele, couleur, puissance, espace)
    {

    }

    public override void afficherCarac()
    {
        Console.WriteLine("Automobile électrique : ");
        Console.WriteLine("Modele : " + modele);
        Console.WriteLine("Couleur : " + couleur);
        Console.WriteLine("Puissance : " + puissance);
        Console.WriteLine("Espace : " + espace);
    }
}