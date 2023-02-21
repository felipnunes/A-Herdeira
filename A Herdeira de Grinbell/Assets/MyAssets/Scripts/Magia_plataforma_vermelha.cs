using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.PlayerLoop;

public class Magia_plataforma_vermelha : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] GameObject misty;
    [SerializeField] bool inicia_ativo = false;
    [SerializeField] private LayerMask chaoLayer;
    private GameObject gamepadCursor;
    private bool cursorIsOver;

    private void Start()
    {
        this.animator.SetBool("ativa", inicia_ativo);
        gamepadCursor = GameObject.Find("Gamepad_Mouse_icon");
    }

    //Check if the mouse is over the plataform
    private void OnMouseOver()
    {
            CheckMouseInput();                 
    }

    //Check for mouse inputs
    private void CheckMouseInput()
    {
        if (Input.GetMouseButtonDown(1))
        {
            interruptorPlataforma();
        }

    }

   

    public void interruptorPlataforma()
    {
        if (misty.GetComponent<Misty_controller>().quantidade_magias_vermelha > 0)
        {
            if (animator.GetBool("ativa"))
            {
                this.animator.SetBool("ativa", false);
            }

            else
            {
                this.animator.SetBool("ativa", true);
                Debug.Log("Variável ativa do Animator: " + this.animator.GetBool("ativa"));
            }

            misty.GetComponent<Misty_controller>().quantidade_magias_vermelha -= 1;

        }
    }

}
