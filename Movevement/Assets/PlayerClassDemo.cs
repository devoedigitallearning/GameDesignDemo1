using UnityEngine;

/*public class Player
{
    public string playerName;
    public int health;
    public int score;

    //constructor
    public Player(string name, int hp)
    {
        playerName = name;
        health = hp;
        score = 0; //iniiialize score
    }

    //Method
    public void PrintStats()
    {
        Debug.Log(playerName + " has " + health + " HP.");
    }
    public void Addscore(int points)
    {
        score = score + points;
        Debug.Log(playerName + " gained " + points + " points. Total score: " + score);
    }

}*/
public class PlayerClassDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Create an instance of Player
        //Player hero = new Player("Knight", 100);
        //hero.PrintStats();
       // hero.Addscore(50);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
