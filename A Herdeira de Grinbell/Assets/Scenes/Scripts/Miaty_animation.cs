using UnityEngine;

public class Miaty_animation : MonoBehaviour
{
    //SerializeFueld permite visualizar essa variavel privada no editor, permitindo que eu arraste um objeto para ele
    [SerializeField]
    private Animator animator;

    [SerializeField]
    public Rigidbody2D rb;
    
    

    // Update is called once per frame
    void Update() {

        //testa se esta andando para a direita
        if (rb.velocity.x > 0) 
        {
            this.animator.SetBool("Andando_direita",true);
        }
        else
        {
            this.animator.SetBool("Andando_direita", false);
        }

        //testa se esta andando para a esquerda
        if (rb.velocity.x < 0)
        {
            this.animator.SetBool("Andando_esquerda", true);
        }
        else
        {
            this.animator.SetBool("Andando_esquerda", false);
        }

        //testa se esta pulando para a direita
        if (this.animator.GetBool("Esta_no_chao") == false && rb.velocity.x > 0)
        {
            this.animator.SetBool("Pulando_direita", true);
        }
        else
        {
            this.animator.SetBool("Pulando_direita", false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //checa se esta no chao
        if (collision.tag == "chao")
        {
            this.animator.SetBool("Esta_no_chao", true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "chao")
        {
            this.animator.SetBool("Esta_no_chao", false);
        }
    }
}

