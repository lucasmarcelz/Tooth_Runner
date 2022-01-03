using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColetaPasta : MonoBehaviour
{
    [Range(0.1f, 10.0f)] public float distancia = 3;
    private GameObject jogador;
    public GameObject pastaDente;
    public GameObject fioDental;
    public RawImage imgPasta;

    // Start is called before the first frame update
    void Start()
    {
        jogador = GameObject.FindWithTag ("Player");
     
    }

    // Update is called once per frame
    void Update()
    {
           if(Vector3.Distance(transform.position,jogador.transform.position) < distancia){
                ItemJogador.quantItem = (int) 3;
                Debug.Log(ItemJogador.quantItem);
                fioDental.SetActive(true);
                imgPasta.enabled = true;
                pastaDente.SetActive(false);
            }
    }
}
