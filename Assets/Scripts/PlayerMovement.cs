using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float jumpspeed;
    public float inGroundDumping;
    private bool isGrounded;
    private Rigidbody2D rb;
    void Start()
    { 
       rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            rb.linearVelocity = new Vector2(-speed, rb.linearVelocity.y);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.linearVelocity = new Vector2(speed, rb.linearVelocity.y);
        }
        if (isGrounded && (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.Space)))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpspeed);
            isGrounded = false;
        }
        if (isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x * inGroundDumping, rb.linearVelocity.y);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Terrain"))
        {
            isGrounded = true;
        }
    }
}
