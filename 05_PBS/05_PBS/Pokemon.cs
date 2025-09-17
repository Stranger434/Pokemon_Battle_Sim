using System;

public enum Type
{
    Grass,
    Fire,
    Water
}

public abstract class Pokemon
{
    public string Name { get; }
    public Type Strenght { get; set; }
    public Type Weakness { get; set; }


    // Constructor
    public Pokemon(string name, Type strenght, Type weakness)
    {
        Name = name;
        Strenght = strenght;
        Weakness = weakness;
    }

    // Abstract Method
    public abstract string BattleCry();
}
