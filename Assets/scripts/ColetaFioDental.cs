using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColetaFioDental : MonoBehaviour
{
    [Range(0.1f, 10.0f)] public float distancia = 3;
    private GameObject jogador;
    public GameObject fioDental;
    public RawImage imgFioDental;

    // Start is called before the first frame update
    void Start()
    {
        jogador = GameObject.FindWithTag ("Player");
     
    }

    // Update is called once per frame
    void Update()
    {
           if(Vector3.Distance(transform.position,jogador.transform.position) < distancia){
                fioDental.SetActive(false);
                ItemJogador.quantItem = (int) 4;
                Debug.Log(ItemJogador.quantItem);
                imgFioDental.enabled = true;
            }
    }
}
