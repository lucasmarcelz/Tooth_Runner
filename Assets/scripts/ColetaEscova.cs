using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColetaEscova : MonoBehaviour
{
    [Range(0.1f, 10.0f)] public float distancia = 3;
    private GameObject jogador;
    public GameObject escova;
    public GameObject enxaguante;
    public RawImage imgEscova;
    public RawImage imgEnxaguante;
    public RawImage imgPasta;
    public RawImage imgFioDental;

    // Start is called before the first frame update
    void Start()
    {
        jogador = GameObject.FindWithTag ("Player");
        imgEscova.enabled = false;
        imgEnxaguante.enabled = false;
        imgPasta.enabled = false;
        imgFioDental.enabled = false;
        
     
    }

    // Update is called once per frame
    void Update()
    {
           if(Vector3.Distance(transform.position,jogador.transform.position) < distancia){
                ItemJogador.quantItem = (int) 1;
                Debug.Log(ItemJogador.quantItem);
                enxaguante.SetActive(true);
                imgEscova.enabled = true;
                escova.SetActive(false);
            }
    }
}
