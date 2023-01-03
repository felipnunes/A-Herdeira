using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orb_controller : MonoBehaviour
{
   [SerializeField] GameObject misty;
   [SerializeField] AudioSource audio_source;
   [SerializeField] SpriteRenderer sprite_renderer;
   [SerializeField] CircleCollider2D circle_collider;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Misty")
        {

            Transform[] children = this.GetComponentsInChildren<Transform>();

            foreach (Transform child in children)
            {
                if (child.tag == "Orb_Light")
                {
                    child.gameObject.SetActive(false);
                }
            }


            audio_source.Play();
            sprite_renderer.enabled = false;
            circle_collider.enabled = false;
            StartCoroutine(esperaParaDestruir());
            if (this.gameObject.tag == "Orbe_rosa")
            {
                misty.GetComponent<Misty_controller>().quantidade_magias_rosa += 1;
            }
            else
            {
                misty.GetComponent<Misty_controller>().quantidade_magias_vermelha += 1;
            }
        }
    }

    IEnumerator esperaParaDestruir()
    {
        yield return new WaitForSeconds(2);
        Destroy(this.gameObject);
    }
}
