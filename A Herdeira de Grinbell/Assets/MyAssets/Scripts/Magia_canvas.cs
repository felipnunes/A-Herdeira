using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Magia_canvas : MonoBehaviour
{
    private GameObject misty;
    public Text Magia_rosa_texto;
    public Text Magia_vermelha_texto;

    private void Start()
    {
        misty = GameObject.FindGameObjectWithTag("Misty");
    }
    void Update()
    {
        Magia_rosa_texto.text = misty.GetComponent<Misty_controller>().quantidade_magias_rosa.ToString();
        Magia_vermelha_texto.text = misty.GetComponent<Misty_controller>().quantidade_magias_vermelha.ToString();
    }
}
