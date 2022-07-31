using UnityEngine;

public class Misty_controller : MonoBehaviour
{
    Rigidbody2D rb;
    public float velocity;
    public float jump_force;
    private bool on_ground;
    public int quantidade_magias_rosa;
    public int quantidade_magias_vermelha;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && on_ground)
        {
            rb.AddForce(new Vector2(0, 1) * jump_force);
        }
        Debug.Log(rb.velocity.x.ToString());
    }

    private void FixedUpdate()
    {
        float direction = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(direction * velocity * Time.deltaTime, rb.velocity.y);
    }


    public bool GetOnGround()
    {
        return on_ground;
    }
    
  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "chao")
        {
            on_ground = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "chao")
        {
            on_ground = false;
        }
    }

}
