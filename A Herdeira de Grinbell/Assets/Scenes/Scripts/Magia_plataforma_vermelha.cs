using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magia_plataforma_vermelha : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] GameObject misty;
   
    private void Update()
    {
        if (misty.GetComponent<Misty_controller>().quantidade_magias_vermelha > 0)
        {
            if (Input.GetMouseButtonDown(1) && animator.GetBool("ativa"))
            {
                animator.SetBool("ativa", false);
                misty.GetComponent<Misty_controller>().quantidade_magias_vermelha -= 1;
          
            }
            else if (Input.GetMouseButtonDown(1) && animator.GetBool("ativa") == false)
            {
                animator.SetBool("ativa", true);
                misty.GetComponent<Misty_controller>().quantidade_magias_vermelha -= 1;

            }
        }
    }

}
