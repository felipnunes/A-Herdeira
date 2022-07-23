using UnityEngine;

public class Misty_controller : MonoBehaviour
{
    Rigidbody2D rb;
    public float velocity = 100;
    public float jump_force = 300;
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
            on_ground = false;
        }
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A)) 
        {
            rb.velocity = new Vector2(-1 * velocity * Time.deltaTime, rb.velocity.y);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(1 * velocity * Time.deltaTime, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "chao")
        {
            on_ground = true;
        }
    }

    public bool GetOnGround()
    {
        return on_ground;
    }

}
