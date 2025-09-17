    using System.Xml.Linq;

public class Trainer
{
    //Fields
    public string name { get; }
    public List<Pokeball> Pokeballs { get; set; }

    //Constructor
    public Trainer(string Name)
    {
        name = Name;
        Pokeballs = new List<Pokeball>();
    }

    //Methods
    public void ReturnPokeball(Pokeball p)
    {
        Pokeballs.Add(p);
    }

    public void ThrowPokeball(int index)
    {
       Pokeball p = Pokeballs[index];
        if (!p.isEmpty)
        {
            //p.ThrowBall();
            Pokeballs.RemoveAt(index);
        }
    }

    //public void ShowPokeBalls()
    //{
    //    Console.WriteLine($"{name} PokeBalls");
    //    foreach (var p in Pokeballs)
    //    {
    //        Console.WriteLine(p.Pokemon);
    //    }
    //}
}
