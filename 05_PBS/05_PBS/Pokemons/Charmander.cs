public class Charmander : Pokemon
{

    // Constructor
    public Charmander(string name, Type strenght, Type weakness) : base(name, strenght, weakness)
    {
    }

    // Methods
    public override string BattleCry()
    {
        return (this.Name);
    }
}
