using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magia_mouse : MonoBehaviour
{
    bool esta_sendo_segurado = false;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (esta_sendo_segurado)
        {
            Vector2 mouse_position = Input.mousePosition;
            mouse_position = Camera.main.ScreenToWorldPoint(mouse_position);

            this.gameObject.transform.localPosition = new Vector3(this.gameObject.transform.localPosition.x, mouse_position.y, 0);
        }
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 mouse_position = Input.mousePosition;
            mouse_position = Camera.main.ScreenToWorldPoint(mouse_position);

            esta_sendo_segurado = true;
        }
        
    }

    private void OnMouseUp()
    {
        esta_sendo_segurado = false;
    }
}
