using UnityEngine;

public class CollisionDemo1 : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Player collided with " + collision.gameObject.name);
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
