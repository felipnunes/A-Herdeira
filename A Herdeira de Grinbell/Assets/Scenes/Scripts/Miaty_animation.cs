using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Miaty_animation : MonoBehaviour
{

    Rigidbody2D rb;
    Animator animator;
    SpriteRenderer spriteRenderer;
    public float initial_position_x;
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
            spriteRenderer.flipX = true;
            animator.SetBool("andando",true);
        }
        else if (rb.velocity.x > 0)
        {
            spriteRenderer.flipX = false;
            animator.SetBool("andando", true);
        }
        else
        {
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

