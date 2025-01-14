using System;

public abstract class Pokemon
{
    // Fields
    public string Name;
    public string Strenght;
    public string Weakness;

    // Constructor
    public Pokemon(string name, string strenght, string weakness)
    {
        this.Name = name;
        this.Strenght = strenght;
        this.Weakness = weakness;
    }

    // Methods
    public abstract string BattleCry();
}