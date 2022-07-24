using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_screen : MonoBehaviour
{
    private GameObject Pause_canvas;
    private GameObject botão_menu;
    private bool pausado;

    private void Start()
    {
        Pause_canvas = GameObject.Find("Pause_panel");
        botão_menu = GameObject.Find("Menu_button");
        Pause_canvas.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && pausado == false)
        {
            pausado = true;
            //Time.timeScale = 0f;
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
            //Time.timeScale = 1f;
            Pause_canvas.SetActive(false);

            //toca som de pause
            if (this.name == "Pause_Canvas")
            {
                this.GetComponent<AudioSource>().Play();
            }

        }  
        
    }

  
    
}
