using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Miaty_animation : MonoBehaviour
{

    Rigidbody2D rb;
    Animator animator;
    SpriteRenderer spriteRenderer;
    public float initial_position_x;
    public bool is_walking;
    private void Start()
    {
        initial_position_x = this.transform.position.x;
        rb = this.GetComponent<Rigidbody2D>();
        animator = this.GetComponent<Animator>();
        spriteRenderer = this.GetComponent<SpriteRenderer>();
    }



    // Update is called once per frame
    void Update() {

        

        if (rb.velocity.x < 0)
        {
            is_walking = true;
            spriteRenderer.flipX = true;
            animator.SetBool("andando",true);

            animator.speed = Mathf.Abs(this.GetComponent<Misty_controller>().direction);

        }
        else if (rb.velocity.x > 0)
        {
            is_walking = true;
            spriteRenderer.flipX = false;
            animator.SetBool("andando", true);

            animator.speed = Mathf.Abs(this.GetComponent<Misty_controller>().direction);
        }
        else
        {
            is_walking = false;
            animator.speed = 1;
            animator.SetBool("andando", false);
        }

        if (this.GetComponent<Misty_controller>().GetOnGround())
        {
            animator.SetBool("on_ground",true);
        }
        else{
            animator.SetBool("on_ground", false);
        }

        
        

    }


    
}

