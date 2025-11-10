using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int score;

    void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public void AddScore(int points)
    {
        score += points;
        Debug.Log("Score: " + score);
       // UIManager.instance.UpdateScore(score);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
