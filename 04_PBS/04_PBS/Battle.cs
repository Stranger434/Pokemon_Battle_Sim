using System.Security.Cryptography.X509Certificates;

class Battle
{
    public Trainer trainer1;
    public Trainer trainer2;
    public int trainer1wins;
    public int trainer2wins;
    public int rounds;
    

    // Constructor
    public Battle()
    {
        rounds = 0;
    }

    // Methods
    public string fight(Pokemon p1, Pokemon p2, Trainer trainer1, Trainer trainer2)
    {
        rounds++;
        Pokeball pokeball1 = new Pokeball(false, false, p1);
        Pokeball pokeball2 = new Pokeball(false, false, p2);


        if (p1.Strenght == p2.Weakness)
        {
            trainer1.ReturnPokeball(pokeball1);
            Console.WriteLine($"{p1.Name} Stayed {p2.Name} Returned");
            return $"{p1.Name} is sterk tegen {p2.Name}. {p1.Name} wint!";
        }
        else if (p2.Strenght == p1.Weakness)
        {
            trainer2.ReturnPokeball(pokeball2);
            Console.WriteLine($"{p2.Name} Stayed {p1.Name} Returned");
            return $"{p2.Name} is sterk tegen {p1.Name}. {p2.Name} wint!";
        }
        else
        {
            trainer1.ReturnPokeball(pokeball1);
            trainer2.ReturnPokeball(pokeball2);
            Console.WriteLine($"both Returned");
            return $"{p1.Name} en {p2.Name} zijn even sterk. Het is een gelijkspel!";
        }

    }

    public int GetRounds()
    {
        return rounds;
    }
}
    