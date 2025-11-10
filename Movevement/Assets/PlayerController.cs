using UnityEngine;
[RequireComponent(typeof(Rigidbody))]

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float currentSpeed;
    public float sprintMultiplier = 2f;
    public float jumpForce = 5f;
    
    private Rigidbody rb;
    private  bool isGrounded = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void HandleMovement()
    {
        float horizontal = Input.GetAxis("Horizontal"); // A/D or Left/Right
        float vertical = Input.GetAxis("Vertical");   // W/S or Up/Down
        Vector3 direction = new Vector3(horizontal, 0, vertical);
        float currentSpeed = Input.GetKey(KeyCode.LeftShift) ? moveSpeed * sprintMultiplier : moveSpeed;

        

        //Calculate movement vector
        Vector3 movement = direction.normalized * currentSpeed * Time.deltaTime;

        rb.MovePosition(transform.position + movement);
    }
    
    void HandleJump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
        
    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                currentSpeed *= sprintMultiplier;
            }
        HandleMovement();
        HandleJump();
        
        
    }
}
