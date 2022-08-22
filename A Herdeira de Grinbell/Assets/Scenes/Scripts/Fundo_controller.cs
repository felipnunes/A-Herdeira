using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fundo_controller : MonoBehaviour
{

    GameObject Misty;
    GameObject fundo_2;
    GameObject fundo_3;

    void Start()
    {
        fundo_2 = GameObject.Find("Caverna_2");
        fundo_3 = GameObject.Find("Caverna_3");
        Misty = GameObject.Find("Misty");
    }

    private void FixedUpdate()
    {
        if (Misty.GetComponent<Rigidbody2D>().velocity.x != 0)
        {

        Vector2 vector_fundo_2 = new Vector2(Misty.GetComponent<Rigidbody2D>().velocity.x * -0.05f, Misty.GetComponent<Rigidbody2D>().velocity.y * -0.01f);
        fundo_2.GetComponent<Rigidbody2D>().velocity = vector_fundo_2;

        Vector2 vector_fundo_3 = new Vector2(Misty.GetComponent<Rigidbody2D>().velocity.x * -0.025f, fundo_3.GetComponent<Rigidbody2D>().velocity.y * -0.005f);
        fundo_3.GetComponent<Rigidbody2D>().velocity = vector_fundo_3;

        }
        else
        {
            fundo_2.GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
            fundo_3.GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
        }
    }

}
