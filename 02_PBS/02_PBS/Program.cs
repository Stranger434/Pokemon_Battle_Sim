using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;

        while (!quit) {
            Console.WriteLine("Enter First Trainer Name:");
            string FirstTrainerName = Console.ReadLine();
            Console.WriteLine("Enter Second Trainer Name:");
            string SecondTrainerName = Console.ReadLine();
            Console.WriteLine(" ");

            Trainer trainer1 = new Trainer(FirstTrainerName);
            Trainer trainer2 = new Trainer(SecondTrainerName);
            Charmander charmander = new Charmander("Char", "Fire", "Water");
            // Compositie want er zit een Charmander object in de Pokeball
            Pokeball pokeball = new Pokeball(false, false, charmander);

        for (int i = 0; i < 6; i++)
            {
                trainer1.ReturnPokeball(pokeball);
                trainer2.ReturnPokeball(pokeball);
            }

            while (trainer1.Pokeballs.Count > 0 & trainer2.Pokeballs.Count > 0)
            {
                trainer1.ThrowPokeball(0);
                Console.WriteLine(trainer1.name + " Heeft een Ball gegooit");
                Console.WriteLine($"{trainer1.name} heeft {trainer1.Pokeballs.Count} PokeBall(s)");
                Console.WriteLine(charmander.BattleCry());


                trainer2.ThrowPokeball(0);
                Console.WriteLine(trainer2.name + " Heeft een Ball gegooit");
                Console.WriteLine($"{trainer2.name} heeft {trainer2.Pokeballs.Count} PokeBall(s)");
                Console.WriteLine(charmander.BattleCry());


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