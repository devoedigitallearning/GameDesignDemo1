using UnityEngine;
public class CollisionDemo : MonoBehaviour
{
        public AudioClip coinSound = null;

    public int score= 0;
    public int points = 0;

             private bool isGrounded = true;

    /*void OnCollisionEnter(Collision collision)
   {
       Debug.Log("Player collided with " + collision.gameObject.name);
   }*/
   /* void OnTriggerEnter(Collider other)
    {
         Debug.Log("Player entered trigger zone: " + other.name);
    }*/
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Wall")
        {
            Debug.Log("Ouch! You hit the Wall!");
            score += points;
            // UIManager.instance.UpdateScore(score);
        }

        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            Debug.Log("Landed!");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Coin")
        {
           // AudioSource.PlayClipAtPoint(coinSound, transform.position);

            Debug.Log("Coin collected!");
            GameManager.instance.AddScore(1);
            Destroy(other.gameObject);
            
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
  /*  void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/
}
