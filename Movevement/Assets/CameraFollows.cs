using UnityEngine;

public class CameraFollows : MonoBehaviour
{
    public Transform player;
    public Vector3 offset = new Vector3(0, 5, -7);
    public float smoothSpeed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   /** void Start()
    {
        
    }*/

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 desiredPosition = player.position + offset;
        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.LookAt(player);
        
    }
}
