namespace Animal;
public class Animal
{
    public string Nom {  get; set; }
    public bool AFaim { get; set; }
    public DateTime DernierRepas {  get; set; }
    public float CoutDuRepas { get; set; }
    public Animal(string Nom,bool AFaim, DateTime DernierRepas, float CoutDuRepas)
    {
        
        this.Nom = Nom;
        this.AFaim = false;
        this.DernierRepas = DernierRepas;
        this.CoutDuRepas = CoutDuRepas;
    }

    public virtual void SExprimer()
    {  
    }




}

