using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause_screen : MonoBehaviour
{
    private GameObject Pause_canvas;
    private bool pausado;

    private void Start()
    {
        Pause_canvas = GameObject.Find("Pause_panel");
        Pause_canvas.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && pausado == false)
        {
            pausado = true;
            Time.timeScale = 0f;
            Pause_canvas.SetActive(true);
            
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && pausado == true)
        {
            pausado = false;
            Time.timeScale = 1f;
            Pause_canvas.SetActive(false);

        }
    }
}
