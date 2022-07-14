using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_controller : MonoBehaviour
{

    public Transform pointer;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouse_position = Input.mousePosition;
        mouse_position.z = 0.5f;

        pointer.position = Camera.main.ScreenToWorldPoint(mouse_position);
    }
}
