internal static class PokemonCheck
{
    public static string Check(Trainer trainer, object p, Pokemon pokemon1, Pokemon pokemon2, Pokemon pokemon3)
    {
        if (trainer.Pokeballs.Count > 0)
        {
            if (p == pokemon1)
            {
                return pokemon1.BattleCry();
            }
            else if (p == pokemon2)
            {
                return pokemon2.BattleCry();
            }
            else if (p == pokemon3)
            {
                return pokemon3.BattleCry();
            }
        }

        return "Dat is geen pokemon jammer man";
    }
}