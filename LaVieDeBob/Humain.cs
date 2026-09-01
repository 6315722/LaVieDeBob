class humain
{
    public string Nom { get; set; }
    public int Age { get; set; }
    public float Capital; 
    public humain(string nom, int age, float capital)
    {
        Nom = nom;
        Age = age;
        Capital = capital;
    }
    public void SePresenter()
    {
        Console.WriteLine($"Bonjour, je m'appelle {Nom} et j'ai {Age} ans. J'ai {Capital} dollars.");
    }

}
