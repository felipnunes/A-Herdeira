using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class portal_controller : MonoBehaviour
{
    private GameObject levelLoader;
    public string proxima_fase;
    private GameObject misty;

    private void Start()
    {
        misty = GameObject.FindGameObjectWithTag("Misty");
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
        misty.GetComponent<Misty_controller>().enabled = false;
        misty.GetComponent<Rigidbody2D>().velocity = misty.GetComponent<Rigidbody2D>().velocity * 0.1f;
        yield return new WaitForSeconds(1.0f);
        Carrega_cenas(proxima_fase);
    }
    
}
