using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_controller : MonoBehaviour
{

    public Animator transition_animation;
    public void Transition(string cena) 
    {
        StartCoroutine(Carrega_cena(cena));
    }

    public void Sair()
    {
        Application.Quit();
    }

    IEnumerator Carrega_cena(string cena)
    {

        transition_animation.SetTrigger("Start");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(cena);

    }

     public IEnumerator ReestartRoutine()
    {
        transition_animation.SetTrigger("Start");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


}
