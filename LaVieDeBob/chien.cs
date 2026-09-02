namespace Animal;
public class Chien : Animal
{
    public string Race { get; set; }

    public Chien(string Nom, bool AFaim, DateTime DernierRepas, float CoutDuRepas, String Race) : base(Nom, AFaim, DernierRepas, CoutDuRepas)
    {
        Race = Race;
    }

    public override void SExprimer()
    {
        Console.WriteLine("Wouf! Wouf!");
        
    }


}