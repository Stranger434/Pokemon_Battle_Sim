

using System.Security.Cryptography.X509Certificates;

class Pokeball
{
    //Fields
    public bool isOpen;
    public bool isEmpty;
    public object Pokemon;

    // Constructor
    public Pokeball(bool isOpen, bool isEmpty, object Pokemon)
    {
        this.isOpen = isOpen;
        this.isEmpty = isEmpty;
        this.Pokemon = Pokemon;
    }

    //Methods
    public bool OpenBall()
    {
        return isOpen = true;
    }

    public bool CloseBall()
    {
        return isOpen = false;
    }

    public object ThrowBall()
    {   
        OpenBall();
        isEmpty = true;
        return Pokemon = null;
    }

    public object StorePokemon(object pokemon)
    {
        CloseBall();
        isEmpty = false;
        return Pokemon = pokemon;
    }
}