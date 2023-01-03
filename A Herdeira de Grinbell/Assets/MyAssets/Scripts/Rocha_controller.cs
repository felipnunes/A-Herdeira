using UnityEngine;
using TMPro;
using System;

public class Rocha_controller : MonoBehaviour
{

    [SerializeField] float tempo_de_espera;
    [SerializeField] float gravidade;
    [SerializeField] TextMeshPro texto;
    private GameObject misty;
    void Start()
    {
        misty = GameObject.Find("Misty");
        this.GetComponent<Rigidbody2D>().gravityScale = 0;
        texto.text = tempo_de_espera.ToString();
    }

    private void Update()
    {
       
        if (tempo_de_espera > 0)
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
