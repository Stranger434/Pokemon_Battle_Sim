using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

public class Battle
{
    public Trainer trainer1;
    public Trainer trainer2;
    public int trainer1wins;
    public int trainer2wins;
    public int rounds;
    private string lastWinner;


    // Constructor
    public Battle(Trainer trainer1, Trainer trainer2)
    {
        this.trainer1 = trainer1;
        this.trainer2 = trainer2;
        this.rounds = 0;
    }

    // Methods
    public string fight(Pokemon p1, Pokemon p2)
    {
        rounds++;
        Pokeball pokeball1 = new Pokeball(false, false, p1);
        Pokeball pokeball2 = new Pokeball(false, false, p2);

        Console.WriteLine($"lastWinner: {lastWinner}");
        Console.WriteLine($"trainer1.name: {trainer1.name}");
        Console.WriteLine($"trainer2.name: {trainer2.name}");

        if (p1.Strenght == p2.Weakness)
        {
            trainer1.ReturnPokeball(pokeball1);
            //Console.WriteLine(trainer1.name + "Won");
            Console.WriteLine($"{p1.Name} Stayed {p2.Name} dood");
            lastWinner = trainer1.name;
            Console.WriteLine("LastWinner update check " + lastWinner);
            return $"{p1.Name} is sterk tegen {p2.Name}. {p1.Name} wint!";
        }
        else if (p2.Strenght == p1.Weakness)
        {
            trainer2.ReturnPokeball(pokeball2);
            //Console.WriteLine(trainer2.name + "Won");
            Console.WriteLine($"{p2.Name} Stayed {p1.Name} dood");
            lastWinner = trainer2.name;
            Console.WriteLine(lastWinner);

            return $"{p2.Name} is sterk tegen {p1.Name}. {p2.Name} wint!";
        }
        else
        {

            Console.WriteLine(lastWinner);

            if (lastWinner == trainer1.name)
            {
                trainer1.ReturnPokeball(pokeball1);
                Console.WriteLine($"{p1.Name} Stayed {p2.Name} dood");
                return $"{p1.Name} won cuz Previous win";
            }

            else if (lastWinner == trainer2.name)
            {
                trainer2.ReturnPokeball(pokeball1);
                Console.WriteLine($"{p2.Name} Stayed {p1.Name} dood");
                return $"{p2.Name} won cuz Previous win";
            }

            else
            {
                trainer1.ReturnPokeball(pokeball1);
                trainer2.ReturnPokeball(pokeball2);
                Console.WriteLine("both Returned");
                return $"{p1.Name} en {p2.Name} zijn even sterk. Het is een gelijkspel!";
            }
        }
    }

    public int GetRounds()
    {
        return rounds;
    }

}
    