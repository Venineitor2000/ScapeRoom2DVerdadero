using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : MonoBehaviour
{
    public GameObject cinematica;
    void Start()
    {
        
        GameObject.FindGameObjectWithTag("Player").SetActive(false);
        foreach (var item in GameObject.FindGameObjectsWithTag("Interactuable"))
        {
            item.gameObject.SetActive(false);
        }
        Timer.victoria = true;
        cinematica.SetActive(true);
    }

    
}
