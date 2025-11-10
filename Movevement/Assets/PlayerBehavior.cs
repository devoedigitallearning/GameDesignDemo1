using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public string playerName = "Hero";
    public int health = 100;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Wall")
        {
            Debug.Log("Ouch! You hit the wall!");
        }

    }
void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name =="Coin")
        {
            //Play sound at coins position
           // AudioSource.PlayClipAtPoint(coinSound, transition.position);

            Debug.Log("Coin collected!");
            GameManager.instance.AddScore(1);
            Destroy(other.gameObject); // Remove coin from scene
        }
    }
    public void TakeDamage(int amount)
    {
        health = health - amount;
        Debug.Log(playerName + " took" + amount + " damage. Health is now " + health);

        if (health <= 0)
        {
            Debug.Log(playerName + " has been defeated! GAME OVER.");
        }
    }
    void Start()
    {
        Debug.Log(playerName + " spawned with " + health + " HP!");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            TakeDamage(20);

        }
        
    }
}
