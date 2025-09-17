using System;

public class Arena
{
    public static int TotalBattles;
    public static int TotalRounds;
    public static int trainer2points;
    public static int trainer1points;

    public static void StartBattleLoop(Trainer trainer1, Trainer trainer2)
    {
        Random rnd = new Random();
        TotalBattles += 1;

        Battle battle = new Battle(trainer1, trainer2);

        while (trainer1.Pokeballs.Count > 0 && trainer2.Pokeballs.Count > 0)
        {
            // Kies willekeurige Pokéball voor beide trainers
            int index1 = rnd.Next(0, trainer1.Pokeballs.Count);
            int index2 = rnd.Next(0, trainer2.Pokeballs.Count);
            //Console.WriteLine(index1);
            //Console.WriteLine(index2);

            Pokemon p1 = (Pokemon)trainer1.Pokeballs[index1].Pokemon;
            Pokemon p2 = (Pokemon)trainer2.Pokeballs[index2].Pokemon;

            trainer1.ThrowPokeball(index1);
            trainer2.ThrowPokeball(index2);

            startBattle(battle, p1, p2);
        }

        Console.WriteLine("Alle Pokéballs zijn opgebruikt. Het gevecht is voorbij!");
        Console.WriteLine($"Totale gevechten: {TotalBattles}");
        Console.WriteLine($"Totale rondes: {TotalRounds}");
    }

    public static void startBattle(Battle battle, Pokemon p1, Pokemon p2)
    {
        string result = battle.fight(p1, p2);
        Console.WriteLine(result);
        TotalRounds += 1;
        Console.WriteLine(TotalRounds + " Rounds\n");
    }
}
