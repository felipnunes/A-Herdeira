using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_controller : MonoBehaviour
{
    Sprite neutro;
    public Sprite rosa;
    public Sprite vermelho;

    public Transform pointer;

    private UnityEngine.Experimental.Rendering.Universal.Light2D componente_luz_mouse;
    // Start is called before the first frame update
    void Start()
    {
        componente_luz_mouse = gameObject.GetComponentInChildren<UnityEngine.Experimental.Rendering.Universal.Light2D>();
        neutro = this.GetComponent<SpriteRenderer>().sprite;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {

        //mouse controoler
        Vector3 mouse_position = Input.mousePosition;
        mouse_position.z = 0.5f;

        pointer.position = Camera.main.ScreenToWorldPoint(mouse_position);

        if (Input.GetMouseButton(0))
        {
            componente_luz_mouse.color = Color.magenta;
            this.GetComponent<SpriteRenderer>().sprite = rosa;
        }
        else if (Input.GetMouseButton(1))
        {
            componente_luz_mouse.color = Color.red;
            this.GetComponent<SpriteRenderer>().sprite = vermelho;
        }
        else
        {
            componente_luz_mouse.color = Color.cyan;
            this.GetComponent<SpriteRenderer>().sprite = neutro;
        }

    }
}
