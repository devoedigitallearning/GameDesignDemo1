using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f; //Player movement speed
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float currentSpeed = 0.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move Forward
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed);
        }

        //Move Backward
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * speed);

        }
    }
}
