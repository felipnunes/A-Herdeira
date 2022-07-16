using UnityEngine;

public class Miaty_animation : MonoBehaviour
{
    //SerializeFueld permite visualizar essa variavel privada no editor, permitindo que eu arraste um objeto para ele
    [SerializeField]
    private Animator animator;

    [SerializeField]
    public Rigidbody2D rb;
    
    

    // Update is called once per frame
    void Update()
    {
        
        //testa se está no chão
        if (rb.velocity.y == 0)
        {
            this.animator.SetBool("Esta_no_chao", true);
        }
        else
        {
            this.animator.SetBool("Esta_no_chao", false);
        }

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
        if (rb.velocity.y != 0 && rb.velocity.x > 0)
        {
            this.animator.SetBool("Pulando_direita", true);
        }
        else
        {
            this.animator.SetBool("Pulando_direita", false);
        }
    }
}
