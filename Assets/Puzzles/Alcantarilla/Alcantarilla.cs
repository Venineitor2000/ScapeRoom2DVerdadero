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
    private void OnEnable()
    {
        if(Pad2.terminado)
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
}
