using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cutscene_animator_controller : MonoBehaviour
{
    [SerializeField] Animator texto_anim;
    [SerializeField] Text texto;
    void Start()
    {
        texto_anim.speed = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (texto.GetComponent<Texto_controller>().GetEsperandoInput())
        {
            texto_anim.speed = 0;
        }
        else
        {
            texto_anim.speed = 1;
        }
    }
    
}
