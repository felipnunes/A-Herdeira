using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magia_plataforma : MonoBehaviour
{
    private bool esta_sendo_segurado = false;
    private bool misty_colidindo = false;
    [SerializeField] GameObject misty;
   

    // Update is called once per frame
    void Update()
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

    private void OnMouseDown()
    {
        if (Input.GetMouseButton(0) && misty.GetComponent<Misty_controller>().quantidade_magias_rosa > 0 && misty_colidindo == false)
        {
            Vector2 mouse_position = Input.mousePosition;
            mouse_position = Camera.main.ScreenToWorldPoint(mouse_position);

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
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Misty")
        {
            misty_colidindo = false;
        }
    }
}
