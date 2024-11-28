using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter Charmanders Nickname");
            string nickname = Console.ReadLine();

            if (nickname == "quit" || nickname == "") { 
                System.Environment.Exit(0);
            }

            Charmander charmander = new Charmander(nickname, "Fire", "Water");
            Console.WriteLine(charmander.nickname + " " + charmander.strenght + " " + charmander.weakness);
            for (int i = 0; i < 10; i++)
            {
                charmander.BattleCry();
            }
        }
    }
}   