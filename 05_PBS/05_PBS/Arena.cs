using System;

public class Arena
{
    public static int TotalBattles { get; set; }
    public static int TotalRounds { get; set; }


    public static void StartBattleLoop(Trainer trainer1, Trainer trainer2, Pokemon pokemon1, Pokemon pokemon2, Pokemon pokemon3)
    {
        Random rnd = new Random();
        TotalBattles += 1;

        while (trainer1.Pokeballs.Count > 0 && trainer2.Pokeballs.Count > 0)
        {
            // Kies willekeurige Pokéball voor beide trainers
            int index1 = rnd.Next(0, trainer1.Pokeballs.Count);
            int index2 = rnd.Next(0, trainer2.Pokeballs.Count);

            Pokemon p1 = (Pokemon)trainer1.Pokeballs[index1].Pokemon;
            Pokemon p2 = (Pokemon)trainer2.Pokeballs[index2].Pokemon;

            trainer1.ThrowPokeball(index1);
            Console.WriteLine(PokemonCheck.Check(trainer1, p1, pokemon1, pokemon2, pokemon3));

            trainer2.ThrowPokeball(index2);
            Console.WriteLine(PokemonCheck.Check(trainer2, p2, pokemon1, pokemon2, pokemon3));

            startBattle(p1, p2, trainer1, trainer2);
        }
    }

    public static void startBattle(Pokemon p1, Pokemon p2, Trainer trainer1, Trainer trainer2)
    {
        Battle battle = new Battle();
        string result = battle.fight(p1, p2, trainer1, trainer2);
        Console.WriteLine(result);
        TotalRounds += battle.GetRounds();
        //Console.WriteLine(TotalRounds + " Rounds");
    }
}
