using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public static float timeLevel = 60f;
    public Text timeLevel_txt;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Vitoria.vitoria == false && Derrota.tempoCabou == false){
        timeLevel -= Time.deltaTime;
        }
        timeLevel_txt.text=timeLevel.ToString("F0");
    }
}
