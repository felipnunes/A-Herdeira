using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class portal_controller : MonoBehaviour
{
    private GameObject levelLoader;
    public string proxima_fase;

    private void Start()
    {
        levelLoader = GameObject.FindWithTag("LevelLoader");
    }
    public void Carrega_cenas(string cena)
    {
        SceneManager.LoadScene(cena);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Misty")
        {
            StartCoroutine(IniciaTransicao());
            
        }
    }

    IEnumerator IniciaTransicao()
    {
        levelLoader.GetComponent<Animator>().SetTrigger("Start");
        yield return new WaitForSeconds(1.0f);
        Carrega_cenas(proxima_fase);
    }
    
}
