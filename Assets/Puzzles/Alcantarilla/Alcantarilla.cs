using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Alcantarilla : MonoBehaviour
{
    public GameObject foto1, foto2;
    public GameObject manija;
    public static bool terminado;
    bool a;
    bool b;
    public AudioSource audioObjeto;
    private void OnEnable()
    {
        Sonar();
        if (Pad2.terminado)
        {
            foto1.SetActive(false);
            foto2.SetActive(true);
        }

       
    }

    public void termino()
    {
        manija.SetActive(false);
        terminado = true;
    }

    
    private void Sonar()
    {
        if (!a)
        {
            a = true;
            audioObjeto.Play();
            SonidosManager.AudiosReproduciendose = true;
        }

    }

    private void Update()
    {
        if (a && !audioObjeto.isPlaying && !b)
        {
            SonidosManager.AudiosReproduciendose = false;
            b = true;
        }
    }
}
