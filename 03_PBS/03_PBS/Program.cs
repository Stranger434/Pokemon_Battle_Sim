//Pokemon pokemon1 = new Squirtle("Squ", "Water", "Leaf");
//Pokemon pokemon2 = new Bulbasaur("Bulba", "Grass", "Fire");
//Pokemon pokemon3 = new Charmander("Char", "Fire ", "Water");

//Console.WriteLine(pokemon1.BattleCry());
//Console.WriteLine(pokemon2.BattleCry());
//Console.WriteLine(pokemon3.BattleCry());

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

            Trainer trainer1 = new Trainer(FirstTrainerName);
            Trainer trainer2 = new Trainer(SecondTrainerName);
            Pokemon pokemon1 = new Squirtle("Squ", "Water", "Leaf");
            Pokemon pokemon2 = new Bulbasaur("Bulba", "Grass", "Fire");
            Pokemon pokemon3 = new Charmander("Char", "Fire ", "Water");
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

            while (trainer1.Pokeballs.Count > 0 && trainer2.Pokeballs.Count > 0)
            {
                object p1 = trainer1.Pokeballs[0].Pokemon;
                trainer1.ThrowPokeball(0);
                Console.WriteLine("Trainer "+ trainer1.name + " Heeft een Ball gegooit");
                Console.WriteLine($"Trainer {trainer1.name} heeft {trainer1.Pokeballs.Count} PokeBall(s)");
                //Console.WriteLine(p1);
                Console.WriteLine(PokemonCheck.Check(trainer1, p1, pokemon1, pokemon2, pokemon3));


                object p2 = trainer2.Pokeballs[0].Pokemon;
                trainer2.ThrowPokeball(0);
                Console.WriteLine("Trainer " + trainer2.name + " Heeft een Ball gegooit");
                Console.WriteLine($"Trainer {trainer2.name} heeft {trainer2.Pokeballs.Count} PokeBall(s)");
                //Console.WriteLine(p2);
                Console.WriteLine(PokemonCheck.Check(trainer2, p2, pokemon1, pokemon2, pokemon3));

            }

            Console.WriteLine("Q to quit / R to Restart");
            string QuitOption = Console.ReadLine();
            if (QuitOption == "Q" || QuitOption == "q")
            {
                quit = true;
            }
        }
    }
}