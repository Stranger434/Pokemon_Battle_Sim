class Bulbasaur : Pokemon
{
    // Constructor
    public Bulbasaur(string name, string strenght, string weakness) : base(name, strenght, weakness)
    {
    }

    // Methods
    public override string BattleCry()
    {
        return (this.Name);
    }
}