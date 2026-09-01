using static System.Runtime.InteropServices.JavaScript.JSType;

classDiagram

    class Humain
{
        -String nom
        +getNom() String
}

class Programmeur
{
        -double salaireHoraire
        -Compte compte
        -Animal[] animaux
        +travailler(double heures)
        +deposer(double montant)
        +retirer(double montant)
        +nourrirChat()
        +nourrirChien()
    }

class Compte
{
        -double solde
        +deposer(double montant)
        +retirer(double montant)
        +getSolde() double
}

class Animal
{
        <<abstract>>
        -String nom
        -boolean aFaim
        -DateTime dernierRepas
        +sExprimer() *
        +manger()
        + peutManger() boolean
        +aFaim() boolean
}

class Chat
{
        -double coutRepas = 5.00
        - int delaiRepas = 10
        +sExprimer()
    }

class Chien
{
        -double coutRepas = 8.00
        - int delaiRepas = 8
        +sExprimer()
    }

class Temps
{
        -DateTime dateHeure
        +avancerHeures(double heures)
        +avancerMinutes(double minutes)
        +maintenant() DateTime
}

Humain <| --Programmeur
    Animal <| --Chat
    Animal <| --Chien

    Programmeur "1" *-- "1" Compte
    Programmeur "1" *-- "2" Animal
    Animal --> Temps : utilise