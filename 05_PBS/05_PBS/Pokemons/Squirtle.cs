public class Squirtle : Pokemon
{
    // Constructor
    public Squirtle(string name, Type strenght, Type weakness) : base(name, strenght, weakness)
    {
    }

    // Methods
    public override string BattleCry()
    {
        return (this.Name);
    }
}