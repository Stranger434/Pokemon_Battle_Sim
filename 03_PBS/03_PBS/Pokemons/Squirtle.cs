class Squirtle : Pokemon
{
    // Constructor
    public Squirtle(string name, string strenght, string weakness) : base(name, strenght, weakness)
    {
    }


    // Methods
    public override string BattleCry()
    {
        return (this.Name);
    }
}