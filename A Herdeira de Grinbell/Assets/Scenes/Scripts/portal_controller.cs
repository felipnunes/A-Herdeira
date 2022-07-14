using UnityEngine;
using UnityEngine.SceneManagement;

public class portal_controller : MonoBehaviour
{
    public void Carrega_cenas(string cena)
    {
        SceneManager.LoadScene(cena);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Misty")
        {
            Carrega_cenas("Fase_2");
        }
    }
}
