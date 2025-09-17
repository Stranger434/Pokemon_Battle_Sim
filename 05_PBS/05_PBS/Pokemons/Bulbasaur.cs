public class Bulbasaur : Pokemon
{
    // Constructor
    public Bulbasaur(string name, Type strenght, Type weakness) : base(name, strenght, weakness)
    {
    }

    // Methods
    public override string BattleCry()
    {
        return (this.Name);
    }
}