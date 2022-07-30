using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magia_plataforma_rosa : MonoBehaviour
{
    private bool esta_sendo_segurado = false;
    private bool misty_colidindo = false;
    [SerializeField] GameObject misty;
   
    void Update()
    {
        if (misty.GetComponent<Misty_controller>().GetOnGround())
        {
            Vector2 mouse_position = Input.mousePosition;
            mouse_position = Camera.main.ScreenToWorldPoint(mouse_position);

            if (esta_sendo_segurado && this.name == "Plataforma_rosa_vertical" && misty_colidindo == false)
            {
                this.gameObject.transform.localPosition = new Vector3(this.gameObject.transform.localPosition.x, mouse_position.y, 0);
            }
            if (esta_sendo_segurado && this.name == "Plataforma_rosa_horizontal" && misty_colidindo == false)
            {
                this.gameObject.transform.localPosition = new Vector3(mouse_position.x, this.gameObject.transform.localPosition.y, 0);
            }
        }
        else if (esta_sendo_segurado)
        {
            esta_sendo_segurado = false;
        }
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButton(0) && misty.GetComponent<Misty_controller>().quantidade_magias_rosa > 0 && misty_colidindo == false && misty.GetComponent<Misty_controller>().GetOnGround())
        {
            esta_sendo_segurado = true;
            misty.GetComponent<Misty_controller>().quantidade_magias_rosa -= 1;
        }        
    }

    private void OnMouseUp()
    {
        esta_sendo_segurado = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Misty")
        {
            misty_colidindo = true;
        }
        else if (collision.tag == "chao")
        {
            misty_colidindo = true;
            Debug.Log("colidiu com a tag chao");
        }
        else
        {
            misty_colidindo = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Misty" || collision.tag == "chao")
        {
            misty_colidindo = false;
        }
    }
}
