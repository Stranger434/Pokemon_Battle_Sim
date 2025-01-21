class Program
{
    static void Main(string[] args)
    {
        bool quit = false;

        while (!quit)
        {
            Console.WriteLine("Enter First Trainer Name:");
            string FirstTrainerName = Console.ReadLine();
            Console.WriteLine("Enter Second Trainer Name:");
            string SecondTrainerName = Console.ReadLine();
            Console.WriteLine(" ");

            Random rnd = new Random();

            Trainer trainer1 = new Trainer(FirstTrainerName);
            Trainer trainer2 = new Trainer(SecondTrainerName);

            // Maak Pokémon aan
            Pokemon pokemon1 = new Squirtle("Squ", "Water", "Grass");
            Pokemon pokemon2 = new Bulbasaur("Bulba", "Grass", "Fire");
            Pokemon pokemon3 = new Charmander("Char", "Fire", "Water");

            // Voeg Pokéballs toe
            Pokeball pokeball1 = new Pokeball(false, false, pokemon1);
            Pokeball pokeball2 = new Pokeball(false, false, pokemon2);
            Pokeball pokeball3 = new Pokeball(false, false, pokemon3);

            for (int i = 0; i < 2; i++)
            {
                trainer1.ReturnPokeball(pokeball1);
                trainer1.ReturnPokeball(pokeball2);
                trainer1.ReturnPokeball(pokeball3);

                trainer2.ReturnPokeball(pokeball1);
                trainer2.ReturnPokeball(pokeball2);
                trainer2.ReturnPokeball(pokeball3);
            }

            Arena.StartBattleLoop(trainer1, trainer2, pokemon1, pokemon2, pokemon3);

            Console.WriteLine("Q to quit / R to Restart");
            string QuitOption = Console.ReadLine();
            
            if (QuitOption == "Q" || QuitOption == "q")
            {
                quit = true;
            }
        }
    }
}