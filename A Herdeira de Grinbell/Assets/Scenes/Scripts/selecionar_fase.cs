using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selecionar_fase : MonoBehaviour
{
    [SerializeField] GameObject panel_fases;
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            panel_fases.SetActive(false);
        }
    }

    public void Ativa_canvas_fases()
    {
       panel_fases.SetActive(true);
    }
}
