using UnityEngine;
//Base Class
public class Player
{
    public string playerName;
    public int health;

    public Player(string name, int hp)
    {
        playerName = name;
        health = hp;
    }

    public virtual void PrintStats()
    {
        Debug.Log(playerName + " has " + health + "HP.");

    }
}

// Subclass Knight
public class Knight : Player
{
    public int armor;

    public Knight(string name, int hp, int armorValue):base(name, hp)
    {
        armor = armorValue;
    }

    public override void PrintStats()
    {
        Debug.Log(playerName + " (Knight) has" + health + " HP and " + armor + " armor.");
    }
}
public class InheritanceDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       // Knight k = new Knight("Sir Lancelot", 120, 50);
        //k.PrintStats();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
