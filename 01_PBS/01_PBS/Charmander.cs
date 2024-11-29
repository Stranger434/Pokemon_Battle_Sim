using System.Numerics;
using System.Xml.Linq;

class Charmander
{
    // Fields
    public string nickname;
    public string strenght;
    public string weakness;

    // Constructor
    public Charmander(string nickname, string strenght, string weakness)
    {
        this.nickname = nickname;
        this.strenght = strenght;
        this.weakness = weakness;
    }

    //Methods
    public string BattleCry()
    {
        return (this.nickname);
    }
}

//1.The player start the game.
//2. The player gives a name to a charmander.
//3. The charmander does its battle cry for ten times.
//4. The player can give a new name to the same charmander.
//5. The charmander does its battle cry for ten times.
//6. Repeat 4 and 5 until the player quits the game.