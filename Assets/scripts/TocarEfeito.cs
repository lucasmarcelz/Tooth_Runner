using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TocarEfeito : MonoBehaviour
{
    public AudioSource tocarSom;

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        tocarSom.Play();
    }

}
