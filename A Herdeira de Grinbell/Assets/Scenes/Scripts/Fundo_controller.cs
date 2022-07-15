using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fundo_controller : MonoBehaviour
{

GameObject Misty;

    GameObject fundo_2;
    GameObject fundo_3;


    // Start is called before the first frame update
    void Start()
    {
        fundo_2 = GameObject.Find("Caverna_2");
        fundo_3 = GameObject.Find("Caverna_3");
        Misty = GameObject.Find("Misty");
    }

 
    private void FixedUpdate()
    {

        Vector2 vector_fundo_2 = new Vector2(Misty.GetComponent<Rigidbody2D>().velocity.x * 0.1f, fundo_2.GetComponent<Rigidbody2D>().velocity.y);
        fundo_2.GetComponent<Rigidbody2D>().velocity = vector_fundo_2;

        Vector2 vector_fundo_3 = new Vector2(Misty.GetComponent<Rigidbody2D>().velocity.x * 0.05f, fundo_3.GetComponent<Rigidbody2D>().velocity.y);
        fundo_3.GetComponent<Rigidbody2D>().velocity = vector_fundo_3;

    }

}
