using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orb_controller : MonoBehaviour
{
   [SerializeField] GameObject misty;
   [SerializeField] AudioSource audio_source;
   [SerializeField] SpriteRenderer sprite_renderer;
   [SerializeField] CircleCollider2D circle_collider;

    private float movimento_em_y = 0;
    private float rotacao_em_z = 0;
    private UnityEngine.Experimental.Rendering.Universal.Light2D componente_luz_orbe;

    private void Start()
    {
        componente_luz_orbe = gameObject.GetComponentInChildren<UnityEngine.Experimental.Rendering.Universal.Light2D>();
    }
    private void Update()
    {
        componente_luz_orbe.intensity = 1.5f + Mathf.Sin(movimento_em_y) * 0.25f;
        this.transform.position = new Vector2(this.transform.position.x, this.transform.position.y + Mathf.Sin(movimento_em_y) * 0.1f * Time.deltaTime);
        this.transform.rotation = Quaternion.Euler(0, 0, Mathf.Sin(rotacao_em_z) * 8) ;
        movimento_em_y += 0.04f;
        rotacao_em_z += 0.04f;
    }


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
