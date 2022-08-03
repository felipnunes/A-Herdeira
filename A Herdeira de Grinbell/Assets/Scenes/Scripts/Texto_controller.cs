using System.Collections;
using UnityEngine;
using UnityEngine.UI;

    public class Texto_controller : MonoBehaviour
    {
        [SerializeField] private string[] textos;
        AudioSource audio_source;
        private Text texto_atual;
        private bool esperando_input;


    private void Start()
    {
        esperando_input = false;
    }
    private void Awake()
        {
            
            audio_source = this.GetComponent<AudioSource>();
            texto_atual = this.GetComponent<Text>();
            StartCoroutine(InsereTexto(textos, texto_atual));
        }

        IEnumerator InsereTexto(string[] textos, Text texto_atual)
        {
            for (int i = 0; i < textos.Length; i++)
            {
                for (int j = 0; j < textos[i].Length; j++)
                {
                    
                    texto_atual.text += textos[i][j];
                    audio_source.Play();
                    yield return new WaitForSeconds(0.05f);

                    if (textos[i][j] == '.' && j != textos[i].Length - 1)
                    {
                        esperando_input = true;
                        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
                        esperando_input = false;
                    }
                }

                esperando_input = true;
                yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
                esperando_input = false;
                texto_atual.text = "";
            }
        }

        public bool GetEsperandoInput()
        {
            return esperando_input;
        }

    }

