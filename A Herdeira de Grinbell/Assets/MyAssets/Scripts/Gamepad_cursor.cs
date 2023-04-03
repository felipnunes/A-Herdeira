using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Experimental.Rendering.LWRP;
using UnityEngine.InputSystem;

public class Gamepad_cursor : MonoBehaviour
{
    [SerializeField]
    private float sensibility;
    private float x;
    private float y;
    Rigidbody2D rb;
    private GameObject misty;
    public bool cursor_is_over_plattaform = false;
    private GameObject actual_gameepad_target_platafform;
    Vector2 stick_movement;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        x = Input.GetAxis("HorizontalRightAxis");
        y = Input.GetAxis("VerticalRightAxis");
        if (x != 0 || y != 0) 
        {
            GameObject mouse_icon = GameObject.Find("Mouse_icon");
            mouse_icon.GetComponent<SpriteRenderer>().enabled = false;
        }
        rb.velocity = new Vector2(stick_movement.x * sensibility * Time.deltaTime, stick_movement.y * sensibility * Time.deltaTime);
    }


    public void MoveCursor(InputAction.CallbackContext context)
    {

        stick_movement = context.ReadValue<Vector2>();
        //stick_movement.Normalize();

        Debug.Log("passou");

        
    }


    //Check for gamepad inputs
    public void CheckGamepadLeftInput(InputAction.CallbackContext context)
    {

        if (context.performed)
        {


            CheckCursorOver();

           
        }
    }

    public void CheckGamepadRightInput(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            CheckCursorOver();
        }
      

        if (context.canceled)
        {
            if (actual_gameepad_target_platafform.name.Contains("Plataforma_rosa") )
            {
                actual_gameepad_target_platafform.GetComponent<Magia_plataforma_rosa>().esta_sendo_segurado = false;
              
            }
        }
    }

    private void ApplyRedMagic()
    {
        actual_gameepad_target_platafform.GetComponent<Magia_plataforma_vermelha>().interruptorPlataforma();
    }

    private void ApplyRoseMagic()
    {
        if (!actual_gameepad_target_platafform.GetComponent<Magia_plataforma_rosa>().esta_sendo_segurado)
        {
            Debug.Log("Ativa Magia Rosa!");
            actual_gameepad_target_platafform.GetComponent<Magia_plataforma_rosa>().esta_sendo_segurado = true;
        }
        
    }

    private void CheckCursorOver()
    {
        // Calculate the start position of the ray as the top left of the cursor
        Vector2 startPos = this.transform.position;

        // Shoot a ray from the start position downward
        RaycastHit2D hit = Physics2D.Raycast(startPos, Vector2.down, 0.1f);
        Debug.DrawRay(startPos, new Vector2(0, -1), Color.yellow);
        // Check if the ray hit a red plataform
        if (hit.collider != null && hit.collider.name.Contains("Plataforma_vermelha"))
        {
            actual_gameepad_target_platafform = hit.transform.gameObject;

            cursor_is_over_plattaform = true;
            ApplyRedMagic();
        }
        else if (hit.collider != null && hit.collider.name.Contains("Plataforma_rosa")) {

            actual_gameepad_target_platafform = hit.transform.gameObject;

            cursor_is_over_plattaform = true;
            if (actual_gameepad_target_platafform.GetComponent<Magia_plataforma_rosa>().misty.GetComponent<Misty_controller>().quantidade_magias_rosa > 0)
            {
                actual_gameepad_target_platafform.GetComponent<Magia_plataforma_rosa>().misty.GetComponent<Misty_controller>().quantidade_magias_rosa -= 1;

                ApplyRoseMagic();
            }
        }
        else
        {
            cursor_is_over_plattaform = false;
        }

        Debug.Log(cursor_is_over_plattaform);
    }

}

   