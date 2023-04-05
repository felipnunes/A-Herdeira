using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Misty_controller : MonoBehaviour
{
    Rigidbody2D rb;
    public float velocity;
    public float jump_force;
    private bool on_ground;
    public int quantidade_magias_rosa;
    public int quantidade_magias_vermelha;
    private Collider2D capsuleCollider;
    public LayerMask chaoLayer;
    private ParticleSystem dirt;
    public float direction;



    void Start()
    {
        on_ground = false;
        rb = this.GetComponent<Rigidbody2D>();
        capsuleCollider = this.GetComponent<CapsuleCollider2D>();
        dirt = this.GetComponent<ParticleSystem>();
    }

    void Update()
    {

        UnityEngine.Debug.Log(rb.velocity.x);

        CheckForOnGround();
        if (on_ground && rb.velocity.x != 0)
        {
            CreateDirt();
        }

    }

    private void FixedUpdate()
    {
        direction = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(direction * velocity * Time.deltaTime, rb.velocity.y);
    }


    public void Jump(InputAction.CallbackContext context)
    {

        if (on_ground && context.started)
        {
            CreateDirt();
            this.GetComponent<AudioSource>().Play();
            rb.AddForce(new Vector2(0, 1) * jump_force);
        }
    }

    public void Reestart(InputAction.CallbackContext context)
    {

        if (context.started)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public bool GetOnGround()
    {
        return on_ground;
    }
    private void CheckForOnGround()
    {

        // Get the bounds of the collider
        Bounds bounds = capsuleCollider.bounds;

        // Calculate the start position of the ray as the center of the bottom edge of the collider bounds
        Vector2 startPos = new Vector2(bounds.center.x, bounds.min.y);

        // Shoot a ray from the start position downward
        RaycastHit2D hit = Physics2D.Raycast(startPos, Vector2.down, 0.1f, chaoLayer);
        Debug.DrawRay(startPos, new Vector2(0, -1), Color.yellow);
        // Check if the ray hit anything
        if (hit.collider != null)
        {
            
            on_ground = true;
        }
        else
        {
            on_ground = false;
        }

    }

    private void CreateDirt()
    {
        dirt.Play();
    }


}
