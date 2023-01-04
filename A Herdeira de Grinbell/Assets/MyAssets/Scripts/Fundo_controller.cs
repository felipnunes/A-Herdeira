using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fundo_controller : MonoBehaviour
{

    GameObject Misty;

    GameObject Background_1;
    GameObject Background_2;
    GameObject Background_3;
    GameObject Background_4;

    void Start()
    {
        Background_1 = GameObject.Find("Background_1");
        Background_2 = GameObject.Find("Background_2");
        Background_3 = GameObject.Find("Background_3");
        Background_4 = GameObject.Find("Background_4");
        Misty = GameObject.Find("Misty");
    }

    private void FixedUpdate()
    {
        if (Misty.GetComponent<Rigidbody2D>().velocity.x != 0.0f)
        {

            

            Vector2 vector_fundo_1 = new Vector2(Misty.GetComponent<Rigidbody2D>().velocity.x * -0.05f, Background_3.GetComponent<Rigidbody2D>().velocity.y * -0.05f);
            Background_1.GetComponent<Rigidbody2D>().velocity = vector_fundo_1;

            Vector2 vector_fundo_2 = new Vector2(Misty.GetComponent<Rigidbody2D>().velocity.x * -0.010f, Background_3.GetComponent<Rigidbody2D>().velocity.y * -0.008f);
            Background_2.GetComponent<Rigidbody2D>().velocity = vector_fundo_2;

            Vector2 vector_fundo_3 = new Vector2(Misty.GetComponent<Rigidbody2D>().velocity.x * -0.015f, Background_3.GetComponent<Rigidbody2D>().velocity.y * -0.005f);
            Background_3.GetComponent<Rigidbody2D>().velocity = vector_fundo_3;

            Vector2 vector_fundo_4 = new Vector2(Misty.GetComponent<Rigidbody2D>().velocity.x * -0.02f, Background_3.GetComponent<Rigidbody2D>().velocity.y * -0.005f);
            Background_4.GetComponent<Rigidbody2D>().velocity = vector_fundo_4;

        }
        else
        {
            Background_1.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            Background_2.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            Background_3.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            Background_4.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
    }


}


