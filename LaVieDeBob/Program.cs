namespace Animal;
class main
{
    static void Main(string[] args)
    {
        humain bob = new humain("Bob", 30, 1000.0f);
        Chien chien = new Chien("Rex", true, DateTime.Now, 5.50f, "Labrador");

        chien.SExprimer();

    }
}