class Charmander : Pokemon
{
    // Constructor
    public Charmander(string name, string strenght, string weakness) : base(name, strenght, weakness)
    {
    }

    // Methods
    public override string BattleCry()
    {
        return (this.Name);
    }
}
