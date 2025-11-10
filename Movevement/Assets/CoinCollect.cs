using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    public AudioClip coinSound;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Play sound at coins position
          AudioSource.PlayClipAtPoint(coinSound, transform.position);

            Debug.Log("Coin collected!");
            GameManager.instance.AddScore(1);
            Destroy(gameObject); // Remove coin from scene
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   
}
