using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_controller : MonoBehaviour
{
    Sprite neutro;
    public Sprite rosa;
    public Sprite vermelho;

    public Transform pointer;
    // Start is called before the first frame update
    void Start()
    {
        neutro = this.GetComponent<SpriteRenderer>().sprite;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouse_position = Input.mousePosition;
        mouse_position.z = 0.5f;

        pointer.position = Camera.main.ScreenToWorldPoint(mouse_position);

        if (Input.GetMouseButton(0))
        {
            this.GetComponent<SpriteRenderer>().sprite = rosa;
        }
        else if (Input.GetMouseButton(1))
        {
            this.GetComponent<SpriteRenderer>().sprite = vermelho;
        }
        else
        {
            this.GetComponent<SpriteRenderer>().sprite = neutro;
        }
    }
}
