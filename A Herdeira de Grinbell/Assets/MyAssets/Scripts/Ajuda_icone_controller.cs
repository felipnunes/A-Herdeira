using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ajuda_icone_controller : MonoBehaviour
{
    [SerializeField] GameObject canvas;
    [SerializeField] GameObject pergaminho;
    AudioClip clipOpen;
    AudioClip clipClose;

    private void Start()
    {


        clipOpen = Resources.Load<AudioClip>("openParchment");
        clipClose = Resources.Load<AudioClip>("closeParchment");

    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Misty")
        {
            this.GetComponent<AudioSource>().clip = clipOpen;
            this.GetComponent<AudioSource>().Play();
            canvas.SetActive(true);
            //pergaminho.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Misty")
        {
            this.GetComponent<AudioSource>().clip = clipClose;
            this.GetComponent<AudioSource>().Play();
            canvas.SetActive(false);
            //pergaminho.SetActive(false);
        }
    }
}
