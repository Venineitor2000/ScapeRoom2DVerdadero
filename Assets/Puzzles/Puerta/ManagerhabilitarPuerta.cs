using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerhabilitarPuerta : MonoBehaviour
{
    bool a;
    public GameObject ObjetoInteractuablePuerta;
    private void Update()
    {
        if(a)
            return;
        if(Alcantarilla.terminado)
        {
            a = true;
            ObjetoInteractuablePuerta.SetActive(true);
        }
    }
}
