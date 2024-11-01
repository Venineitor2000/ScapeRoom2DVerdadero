using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerMarcasPared : MonoBehaviour
{
    public AudioSource audioPared;
    bool a;
    bool b;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.tag == "Player")
        {
            if (!a)
            {
                audioPared.enabled = true;
                a = true;
                SonidosManager.AudiosReproduciendose = true;
            }
            
        }
    }

    private void Update()
    {
        if (a && !audioPared.isPlaying && !b)
        {
            SonidosManager.AudiosReproduciendose = false;
            b = true;
        }
            
    }
}
