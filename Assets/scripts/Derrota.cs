using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Derrota : MonoBehaviour
{
    public GameObject somDerrota;
    public Image background;
    public Text texto1;
    public Text texto2;
    public string principal;
    public static bool tempoCabou = false;
    public static float contagem = 5f;
    
    // Start is called before the first frame update
    void Start()
    {
        background.enabled = false;
        texto1.enabled = false;
        texto2.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Timer.timeLevel <= 0f){
            background.enabled = true;
            texto1.enabled = true;
            texto2.enabled = true;
            somDerrota.SetActive(true);
            tempoCabou = true;
            if(tempoCabou == true){
                contagem -= Time.deltaTime;
                if(contagem <= 0){
                    SceneManager.LoadScene(principal);
                }
            }
            
        }
    }
}
