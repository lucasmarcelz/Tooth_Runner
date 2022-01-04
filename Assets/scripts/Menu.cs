using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public string principal;
    // Start is called before the first frame update
    public void MudarCena()
    {
        SceneManager.LoadScene(principal);
        Timer.timeLevel = 60f;
        Vitoria.vitoria = false;
        Derrota.tempoCabou = false;
        Vitoria.contagem = 5f;
        Derrota.contagem = 5f;
        ItemJogador.quantItem = 0;
    }

    // Update is called once per frame
    public void SairCena()
    {
        Application.Quit();
    }
}
