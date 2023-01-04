using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_controll : MonoBehaviour
{
    GameObject Misty;
    void Start()
    {
        Misty = GameObject.Find("Misty");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 vetor_movimento = new Vector2(Misty.GetComponent<Rigidbody2D>().velocity.x * 0.05f, Misty.GetComponent<Rigidbody2D>().velocity.y * 0.02f);
        this.GetComponent<Rigidbody2D>().velocity = vetor_movimento;
    }
}
