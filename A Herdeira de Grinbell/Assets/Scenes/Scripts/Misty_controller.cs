using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Misty_controller : MonoBehaviour
{
    Rigidbody2D rb;
    public float velocity = 100;
    public float jump_force = 300;
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0, 1) * jump_force);
        }
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A)) 
        {
            rb.velocity = new Vector2(-1 * velocity * Time.deltaTime, rb.velocity.y) ;
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
}
