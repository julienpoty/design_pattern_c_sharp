namespace Iterator;

public class Vehicule : Element
{

  public Vehicule(string description) : base(description){}

  public void affiche()
  {
    Console.WriteLine("Description du véhicule : " +
      description);
  }
}
