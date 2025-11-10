using UnityEngine;

public class PlayerPhiysics : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody rb;
    public float jumpForce = 5f;
    private bool isGrounded = true;


    // Start is called once before the first execution of Update after the MonoBehaviour is created


    // Update is called once per frame
    void Start()// unncessary with translate function
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // direct transform change (frame-based)
        float h = Input.GetAxis("Horizontal"); // A/D or Left/Right
        float v = Input.GetAxis("Vertical");   // W/S or Up/Down
        Vector3 move = new Vector3(h, 0, v);
        transform.Translate(move * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
            Debug.Log("Jump!");
        }

    }
    
     void OnCollisionEnter(Collision collision)
    {
        // Reset isGrounded only when hitting Ground object
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            Debug.Log("Landed!");
        }
    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.MovePosition(transform.position + movement * speed * Time.fixedDeltaTime);
    }   

}
