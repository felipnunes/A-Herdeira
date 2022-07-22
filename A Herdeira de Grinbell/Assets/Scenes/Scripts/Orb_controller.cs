using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orb_controller : MonoBehaviour
{
   [SerializeField] GameObject misty;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Misty" && this.tag == "Orbe_rosa")
        {
            Destroy(this.gameObject);
            misty.GetComponent<Misty_controller>().quantidade_magias_rosa += 1;
        }

        if (collision.tag == "Misty" && this.tag == "Orbe_vermelha")
        {
            Destroy(this.gameObject);
            misty.GetComponent<Misty_controller>().quantidade_magias_vermelha += 1;
        }
    }
}
