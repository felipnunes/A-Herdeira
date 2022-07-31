using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_screen : MonoBehaviour
{
    private GameObject Pause_canvas;
    private GameObject botão_menu;
    private bool pausado;
    private GameObject misty;

    private void Start()
    {
        Pause_canvas = GameObject.Find("Pause_panel");
        botão_menu = GameObject.Find("Menu_button");
        misty = GameObject.Find("Misty");
        Pause_canvas.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && pausado == false)
        {
            pausado = true;
            misty.GetComponent<Rigidbody2D>().velocity = new Vector2(0, misty.GetComponent<Rigidbody2D>().velocity.y);
            misty.GetComponent<Misty_controller>().enabled = false;
            Pause_canvas.SetActive(true);
            //toca som de pause
            if (this.name == "Pause_Canvas")
            {
                this.GetComponent<AudioSource>().Play();
            }
            
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && pausado == true)
        {
            pausado = false;
            Pause_canvas.SetActive(false);
            misty.GetComponent<Misty_controller>().enabled = true;

            //toca som de pause
            if (this.name == "Pause_Canvas")
            {
                this.GetComponent<AudioSource>().Play();
            }

        }  
        
    }

  
    
}
