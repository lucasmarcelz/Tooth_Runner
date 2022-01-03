using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Vitoria : MonoBehaviour
{
    [Range(0.1f, 10.0f)] public float distancia = 3;
    private GameObject jogador;
    public Image background;
    public Text texto1;
    public Text texto2;
    public static bool vitoria = false;
    public static float contagem = 5f;
    public GameObject somVitoria;
    public string principal;
    // Start is called before the first frame update
    void Start()
    {
        jogador = GameObject.FindWithTag ("Player");
        background.enabled = false;
        texto1.enabled = false;
        texto2.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        if(ItemJogador.quantItem == 4 && Vector3.Distance(transform.position,jogador.transform.position) < distancia){
            background.enabled = true;
            texto1.enabled = true;
            texto2.enabled = true;
            vitoria = true;
            somVitoria.SetActive(true);
               if(vitoria == true){
                contagem -= Time.deltaTime;
                if(contagem <= 0){
                    SceneManager.LoadScene(principal);
                }
            }
            }
        }
    }


