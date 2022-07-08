namespace AbstractFactory;

public interface FabriqueVehicule
{
    Automobile creerAutomobile(string modele, string couleur, int puissance, double espace);
}