// See https://aka.ms/new-console-template for more information
using AbstractFactory;

Console.WriteLine("Hello, World!");

public class Catalogue
{
    public static int vehiculeNumber = 3;

    static void Main(string[] args)
    {
        FabriqueVehicule fabrique = new FabriqueVehiculeElectrique();
        Automobile auto = fabrique.creerAutomobile("Tesla", "BLeu", 250, 2.5);
        auto.afficherCarac();
    }
}

