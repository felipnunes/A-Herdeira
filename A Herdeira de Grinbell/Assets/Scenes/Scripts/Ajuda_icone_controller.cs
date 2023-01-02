using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ajuda_icone_controller : MonoBehaviour
{
    [SerializeField] GameObject canvas;
    [SerializeField] GameObject pergaminho;

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Misty")
        {
            canvas.SetActive(true);
            //pergaminho.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Misty")
        {
            canvas.SetActive(false);
            //pergaminho.SetActive(false);
        }
    }
}
