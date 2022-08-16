using UnityEngine;
using TMPro;
using System;

public class Rocha_controller : MonoBehaviour
{

    [SerializeField] float tempo_de_espera;
    [SerializeField] float gravidade;
    [SerializeField] TextMeshPro texto;
    private GameObject misty;
    private bool inicia_cronometro;
    void Start()
    {
        inicia_cronometro = false;
        misty = GameObject.Find("Misty");
        this.GetComponent<Rigidbody2D>().gravityScale = 0;
        texto.text = tempo_de_espera.ToString();
    }

    private void Update()
    {
        if (misty.GetComponent<Animator>().GetBool("andando") == true)
        {
            inicia_cronometro = true;
        }
        if (tempo_de_espera > 0 && inicia_cronometro)
        {
            tempo_de_espera -= Time.deltaTime;
            texto.text = tempo_de_espera.ToString();
        }
        else
        {
            this.GetComponent<Rigidbody2D>().gravityScale = gravidade;
        }
    }

}
