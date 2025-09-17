class Pokeball
{
    // Fields
    public bool isOpen;

    public bool isEmpty;
    public Pokemon Pokemon;

    // Constructor
    public Pokeball(bool isOpen, bool isEmpty, Pokemon pokemon)
    {
        this.isOpen = isOpen;
        this.isEmpty = isEmpty;
        this.Pokemon = pokemon;
    }

    // Methods
    public void OpenBall()
    {
        isOpen = true;
    }

    public void CloseBall()
    {
        isOpen = false;
    }

    public Pokemon ThrowBall()
    {
        if (isEmpty || Pokemon == null)
        {
            Console.WriteLine("Deze Pokéball is leeg.");
            return null;
        }

        OpenBall();
        Pokemon releasedPokemon = Pokemon;
        Pokemon = null;
        isEmpty = true;
        return releasedPokemon;
    }

    public void ReturnToBall(Pokemon pokemon)
    {
        if (!isEmpty)
        {
            Console.WriteLine("De Pokéball is al bezet!");
            return;
        }

        Pokemon = pokemon;
        isEmpty = false;
        CloseBall();
        Console.WriteLine($"{pokemon.Name} is terug in de Pokéball.");
    }
}
