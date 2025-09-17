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

            // Squirtles
            Pokemon squirtle1 = new Squirtle("Squ", "Water", "Grass");
            Pokemon squirtle2 = new Squirtle("Squ", "Water", "Grass");
            Pokemon squirtle3 = new Squirtle("Squ", "Water", "Grass");
            Pokemon squirtle4 = new Squirtle("Squ", "Water", "Grass");

            // Bulbasaurs
            Pokemon bulbasaur1 = new Bulbasaur("Bulba", "Grass", "Fire");
            Pokemon bulbasaur2 = new Bulbasaur("Bulba", "Grass", "Fire");
            Pokemon bulbasaur3 = new Bulbasaur("Bulba", "Grass", "Fire");
            Pokemon bulbasaur4 = new Bulbasaur("Bulba", "Grass", "Fire");

            // Charmanders
            Pokemon charmander1 = new Charmander("Char", "Fire", "Water");
            Pokemon charmander2 = new Charmander("Char", "Fire", "Water");
            Pokemon charmander3 = new Charmander("Char", "Fire", "Water");
            Pokemon charmander4 = new Charmander("Char", "Fire", "Water");

            // Pokeballs
            Pokeball pokeball1 = new Pokeball(false, false, charmander1);
            Pokeball pokeball2 = new Pokeball(false, false, charmander2);
            Pokeball pokeball3 = new Pokeball(false, false, squirtle1);
            Pokeball pokeball4 = new Pokeball(false, false, squirtle2);
            Pokeball pokeball5 = new Pokeball(false, false, bulbasaur1);
            Pokeball pokeball6 = new Pokeball(false, false, bulbasaur2);

            Pokeball pokeball7 = new Pokeball(false, false, charmander1);
            Pokeball pokeball8 = new Pokeball(false, false, charmander2);
            Pokeball pokeball9 = new Pokeball(false, false, squirtle1);
            Pokeball pokeball10 = new Pokeball(false, false, squirtle2);
            Pokeball pokeball11 = new Pokeball(false, false, bulbasaur1);
            Pokeball pokeball12 = new Pokeball(false, false, bulbasaur2);


            trainer1.ReturnPokeball(pokeball1);
            trainer1.ReturnPokeball(pokeball2);
            trainer1.ReturnPokeball(pokeball3);
            trainer1.ReturnPokeball(pokeball4);
            trainer1.ReturnPokeball(pokeball5);
            trainer1.ReturnPokeball(pokeball6);

            trainer2.ReturnPokeball(pokeball7);
            trainer2.ReturnPokeball(pokeball8);
            trainer2.ReturnPokeball(pokeball9);
            trainer2.ReturnPokeball(pokeball10);
            trainer2.ReturnPokeball(pokeball11);
            trainer2.ReturnPokeball(pokeball12);

            Arena.StartBattleLoop(trainer1, trainer2);

            Console.WriteLine("Q to quit / R to Restart");
            string QuitOption = Console.ReadLine();
            
            if (QuitOption == "Q" || QuitOption == "q")
            {
                quit = true;
            }
        }
    }
}