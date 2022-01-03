using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColetaEnxaguante : MonoBehaviour
{
    [Range(0.1f, 10.0f)] public float distancia = 3;
    private GameObject jogador;
    public GameObject enxaguante;
    public RawImage imgEnxaguante;
    public GameObject pastaDente;
    // Start is called before the first frame update
    void Start()
    {
        jogador = GameObject.FindWithTag ("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position,jogador.transform.position) < distancia){
           enxaguante.SetActive(false);
           ItemJogador.quantItem = 2;
           Debug.Log(ItemJogador.quantItem);
           pastaDente.SetActive(true);
           imgEnxaguante.enabled = true;
        }
    }
}
