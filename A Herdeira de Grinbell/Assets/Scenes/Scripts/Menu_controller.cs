using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_controller : MonoBehaviour
{
    public void Carrega_cenas(string cena) 
    {
        SceneManager.LoadScene(cena);
    }

    public void Sair()
    {
        Application.Quit();
    }

   
}
